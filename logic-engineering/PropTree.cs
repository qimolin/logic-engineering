using logic_engineering.Operands;
using logic_engineering.Operators;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace logic_engineering
{
    public class PropTree
    {
        public PropNode Root { get; private set; }
        public string Proposition { get; private set; }
        private string _parsedProposition;
        private int _nodeNumber;
        private List<char> _variables;
        private List<char> _operators;
        public PropTree(string proposition)
        {
            this._parsedProposition = StringHandler.RemoveWhiteSpace(proposition);

            ValidateProposition(_parsedProposition);

            _nodeNumber = 0;

            _variables = new List<char>();
            _operators = new List<char>();

            Proposition = _parsedProposition;

            Root = BuildTree(ref _parsedProposition);
        }
        public static void ValidateProposition(string proposition)
        {
            (int openBracket, int closingBracket) = StringHandler.ParenthesesCount(proposition);
            if (proposition.Length == 0)
                throw new ArgumentException("Empty proposition");
            if (openBracket != closingBracket)
                throw new ArgumentException("Unbalanced parentheses count");
            if (openBracket == 0 && closingBracket == 0)
                throw new ArgumentException("Proposition without parentheses is invalid");
            if (proposition.IndexOfAny(new char[] { '~', '>', '=', '&', '|', '1', '0', '%' }) == - 1)
                throw new ArgumentException("Proposition without operators is invalid");
        }
        private string GenerateNodeName()
        {
            return "node" + _nodeNumber++;
        }
        private PropNode BuildTree(ref string proposition)
        {
            char firstChar = proposition[0];
            PropNode node;
            while (Regex.IsMatch(firstChar.ToString(), "[(,)]"))
            {
                StringHandler.RemoveFirstChar(ref proposition);
                if (proposition.Length == 0) break;
                firstChar = proposition[0];
            }
            switch (firstChar)
            {
                case '~':
                    node = new Negation();
                    node.Name = GenerateNodeName();
                    StringHandler.RemoveFirstChar(ref proposition);
                    node.Right = BuildTree(ref proposition);
                    if (!StringHandler.IsCharInList(_operators, node.Value)) _operators.Add(node.Value);
                    return node;
                case '>':
                    node = new Implication();
                    node.Name = GenerateNodeName();
                    StringHandler.RemoveFirstChar(ref proposition);
                    node.Left = BuildTree(ref proposition);
                    node.Right = BuildTree(ref proposition);
                    if (!StringHandler.IsCharInList(_operators, node.Value)) _operators.Add(node.Value);
                    return node;
                case '=':
                    node = new Biimplication();
                    node.Name = GenerateNodeName();
                    StringHandler.RemoveFirstChar(ref proposition);
                    node.Left = BuildTree(ref proposition);
                    node.Right = BuildTree(ref proposition);
                    if (!StringHandler.IsCharInList(_operators, node.Value)) _operators.Add(node.Value);
                    return node;
                case '&':
                    node = new Conjunction();
                    node.Name = GenerateNodeName();
                    StringHandler.RemoveFirstChar(ref proposition);
                    node.Left = BuildTree(ref proposition);
                    node.Right = BuildTree(ref proposition);
                    if (!StringHandler.IsCharInList(_operators, node.Value)) _operators.Add(node.Value);
                    return node;
                case '|':
                    node = new Disjunction();
                    node.Name = GenerateNodeName();
                    StringHandler.RemoveFirstChar(ref proposition);
                    node.Left = BuildTree(ref proposition);
                    node.Right = BuildTree(ref proposition);
                    if (!StringHandler.IsCharInList(_operators, node.Value)) _operators.Add(node.Value);
                    return node;
                case '1':
                    node = new TrueNode();
                    node.Name = GenerateNodeName();
                    return node;
                case '0':
                    node = new FalseNode();
                    node.Name = GenerateNodeName();
                    return node;
                case '%':
                    node = new Nand();
                    node.Name = GenerateNodeName();
                    StringHandler.RemoveFirstChar(ref proposition);
                    node.Left = BuildTree(ref proposition);
                    node.Right = BuildTree(ref proposition);
                    if (!StringHandler.IsCharInList(_operators, node.Value)) _operators.Add(node.Value);
                    return node;
            }
            if (Char.IsLetter(firstChar))
            {
                node = new Variable(firstChar);
                node.Name = GenerateNodeName();
                StringHandler.RemoveFirstChar(ref proposition);
                if (!StringHandler.IsCharInList(_variables, firstChar)) _variables.Add(firstChar);
                return node;
            }
            throw new ArgumentException("Invalid proposition");
        }
        public string ToDotFormat(PropNode node)
        {
            string dotOutput = "";
            dotOutput += $"{node.Name} [ label = \"{node.Value}\" ]";
            if (node.Left != null)
            {
                dotOutput += $"{node.Name}--{node.Left.Name}{Environment.NewLine}";
                dotOutput += ToDotFormat(node.Left);
            }
            if (node.Right != null)
            {
                dotOutput += $"{node.Name}--{node.Right.Name}{Environment.NewLine}";
                dotOutput += ToDotFormat(node.Right);
            }
            return dotOutput;
        }
        public void WriteToFile(string fileName)
        {
            StringBuilder _stringBuilder = new StringBuilder();
            _stringBuilder.Append("graph logic {");
            _stringBuilder.Append($"  node [ fontname = \"Arial\" ]");
            _stringBuilder.Append(ToDotFormat(Root));
            _stringBuilder.Append("}");

            FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            TextWriter textWriter = new StreamWriter(fileStream);
            textWriter.Write(_stringBuilder.ToString());
            textWriter.Close();
        }
        public void GenerateImage()
        {
            Process dot = new Process();
            dot.StartInfo.FileName = @"dot.exe";
            dot.StartInfo.Arguments = "-Tpng -oabc.png abc.dot";
            dot.Start();
            dot.WaitForExit();
        }
        private string ToInfixAscii(PropNode node)
        {
            string infixAscii = "";
            if (node.Left != null)
            {
                if (node.Left is Variable || node.Left is Negation)
                {
                    infixAscii += ToInfixAscii(node.Left);
                }
                else
                {
                    infixAscii += "(";
                    infixAscii += ToInfixAscii(node.Left);
                    infixAscii += ")";
                }
            }
            infixAscii += node.Value;
            if (node.Right != null)
            {
                if (node.Right is Variable || node.Right is Negation)
                {
                    infixAscii += ToInfixAscii(node.Right);
                }
                else
                {
                    infixAscii += "(";
                    infixAscii += ToInfixAscii(node.Right);
                    infixAscii += ")";
                }
            }
            return infixAscii;
        }

        public string ToInfix()
        {
            string infix = ToInfixAscii(Root);
            StringHandler.ReplaceCharWithString(ref infix, '~', "¬");
            StringHandler.ReplaceCharWithString(ref infix, '>', "⇒");
            StringHandler.ReplaceCharWithString(ref infix, '=', "⇔");
            StringHandler.ReplaceCharWithString(ref infix, '&', "⋀");
            StringHandler.ReplaceCharWithString(ref infix, '|', "⋁");
            return infix;
        }
        public List<char> GetUniqueVariables()
        {
            _variables.Sort();
            return _variables;
        }

        public List<char> GetUniqueOperators()
        {
            return _operators;
        }
        public bool Evaluate(Dictionary<char, bool> cases)
        {
            return Root.Evaluate(cases);
        }
        public PropTree Nandify()
        {
            string nand = "";
            if (Proposition.Contains('%'))
            {
                nand = Proposition;
            } 
            else
            {
                nand = Root.Nandify();
            }
            return new PropTree(nand);
        }
    }
}
