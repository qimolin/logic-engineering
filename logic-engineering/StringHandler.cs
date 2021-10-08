using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace logic_engineering
{
    public static class StringHandler
    {
        public static string RemoveWhiteSpace(string input)
        {
            // Source: https://stackoverflow.com/questions/6219454/efficient-way-to-remove-all-whitespace-from-string
            return Regex.Replace(input, @"\s", "");
        }
        public static (int, int) ParenthesesCount(string input)
        {
            int openBracket = 0, closingBracket = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(') openBracket++;
                if (input[i] == ')') closingBracket++;
            }
            return (openBracket, closingBracket);
        }
        public static bool IsCharInList(List<char> charList, char value)
        {
            bool _inList = false;
            if (charList.Count > 0)
            {
                for (int i = 0; i < charList.Count; i++)
                {
                    if (charList[i] == value) _inList = true;
                }
            }
            return _inList;
        }
        public static void RemoveFirstChar(ref string input)
        {
            if (input.Length > 0)
            {
                input = input.Substring(1, input.Length - 1);
            }
            else
            {
                throw new ArgumentException("String is empty");
            }
        }
        public static void ReplaceCharWithString(ref string input, char replace, string value)
        {
            Regex pattern = new Regex($@"[{replace}]");
            input = pattern.Replace(input, value);
        }
        public static List<string> BinaryGenerator(int columns)
        {
            int rows = (int)Math.Pow(2, columns);
            List<string> binaryNumbers = new List<string>();
            for (int i = 0; i < rows; i++)
            {
                binaryNumbers.Add(Convert.ToString(i, 2).PadLeft(columns, '0'));
            }
            return binaryNumbers;
        }
        public static int GetDiffIndex(string first, string second)
        {
            int count = 0, index = -1;
            if (first.Length == second.Length)
            {
                for (int i = 0; i < first.Length; i++)
                {
                    if (first[i] != second[i])
                    {
                        count++;
                        index = i;
                    }
                }
            }
            if (count == 1) return index;
            return -1;
        }
        public static int CountCharWithValue(string input, char value)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == value)
                    count++;
            }
            return count;
        }
        public static bool HasSubsequentChar(string input, char value)
        {
            bool subsequent = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == value)
                {
                    subsequent = true;
                    break;
                }
            }
            return subsequent;
        }
    }
}
