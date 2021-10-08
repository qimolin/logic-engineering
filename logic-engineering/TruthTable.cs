using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace logic_engineering
{
    public class TruthTable
    {
        private PropTree _tree;
        private List<TruthRow> _table;
        private List<TruthRow> _simplifiedTable;
        private List<TruthRow> _falseRows;
        private List<TruthRow> _trueRows;
        public TruthTable(PropTree tree)
        {
            this._tree = tree;

            _table = new List<TruthRow>();
            _simplifiedTable = new List<TruthRow>();
            _trueRows = new List<TruthRow>();
            _falseRows = new List<TruthRow>();

            GenerateTruthTable();
            SimplifyRows(_trueRows);
        }
        private void GenerateTruthTable()
        {
            List<char> variables = _tree.GetUniqueVariables();
            int columns = variables.Count;
            // Generate binary row cases
            List<string> truthCases = StringHandler.BinaryGenerator(columns);
            for (int i = 0; i < truthCases.Count; i++)
            {
                // Dictionary for getting bool value in the Variable node
                Dictionary<char, bool> predicates = new Dictionary<char, bool>();
                for (int j = 0; j < columns; j++)
                {
                    // Add predicate according to truthCase
                    predicates.Add(variables[j], truthCases[i].Substring(j, 1) == "0" ? false : true);
                }
                bool predicateResult = _tree.Evaluate(predicates);
                TruthRow row = new TruthRow(truthCases[i], predicateResult);
                _table.Add(row);
                if (predicateResult) _trueRows.Add(row);
                else _falseRows.Add(row);
            }
        }
        public List<string[]> GetFullRows()
        {
            List<string[]> rows = new List<string[]>();
            for (int i = 0; i < _table.Count; i++)
            {
                rows.Add(_table[i].FullRow);
            }
            return rows;
        }
        public List<string[]> GetSimplifiedRows()
        {
            List<string[]> rows = new List<string[]>();
            for (int i = 0; i < _simplifiedTable.Count; i++)
            {
                rows.Add(_simplifiedTable[i].FullRow);
            }
            return rows;
        }
        public string GetBinaryString()
        {
            string binaryString = "";
            for (int i = _table.Count - 1; i >= 0; i--)
            {
                binaryString += _table[i].Result ? "1" : "0";
            }
            return binaryString;
        }
        public string GetSimplifiedBinaryString()
        {
            string binaryString = "";
            for (int i = _simplifiedTable.Count - 1; i >= 0; i--)
            {
                binaryString += _simplifiedTable[i].Result ? "1" : "0";
            }
            return binaryString;
        }
        public string GetHexaDecimal()
        {
            string hex = GetBinaryString();
            return Convert.ToInt64(hex, 2).ToString("X");
        }
        public string GetSimplifiedHexaDecimal()
        {
            string hex = GetSimplifiedBinaryString();
            return Convert.ToInt64(hex, 2).ToString("X");
        }
        private void SimplifyRows(List<TruthRow> truthRows)
        {
            // Add false rows to simplified table first
            for (int i = 0; i < _falseRows.Count; i++)
            {
                _simplifiedTable.Add(_falseRows[i]);
            }
            // Make a local copy of the truthRows so the input list doesn't get modified
            List<TruthRow> tempRows = truthRows.GetRange(0, truthRows.Count);
            for (int n = 0; n < this._tree.GetUniqueVariables().Count; n++)
            {
                List<TruthRow> rows = tempRows;
                // Set list to intermediate table 
                List<string> simplified = new List<string>();
                // Compare rows against each other
                for (int i = 0; i < rows.Count; i++)
                {
                    for (int j = i + 1; j < rows.Count; j++)
                    {
                        int dcIndex = StringHandler.GetDiffIndex(rows[i].BinaryCase, rows[j].BinaryCase); // don't care index
                        if (dcIndex >= 0)
                        {
                            // To replace dcIndex with * since string is immutable
                            StringBuilder simplifiedString = new StringBuilder(rows[i].BinaryCase);
                            simplifiedString[dcIndex] = '*';
                            string simplifiedRow = simplifiedString.ToString();
                            if (!simplified.Contains(simplifiedRow) /* && ValidateSimplifiedRow(simplifiedRow) */)
                            {
                                simplified.Add(simplifiedRow);
                            }
                            // Set evaluated rows valid to false
                            rows[i].Valid = false;
                            rows[j].Valid = false;
                        }
                    }
                }
                for (int i = 0; i < simplified.Count; i++)
                {
                    // Add rows to table
                    tempRows.Add(new TruthRow(simplified[i], true));
                }
                for (int i = 0; i < tempRows.Count; i++)
                {
                    if (!tempRows[i].Valid)
                    {
                        // Remove invalid (checked) from local simplified table
                        tempRows.RemoveAt(i);
                        i--;
                    }
                }
            }
            for (int i = 0; i < tempRows.Count; i++)
            {
                if (tempRows[i].Valid)
                {
                    // Add valid (checked) to simplified table
                    _simplifiedTable.Add(tempRows[i]);
                }
            }
        }
        private List<string> GenerateVerificationRows(string row)
        {
            List<string> replacedRows = new List<string>();
            int asteriskCount = StringHandler.CountCharWithValue(row, '*');
            if (asteriskCount > 0)
            {
                List<string> cases = StringHandler.BinaryGenerator(asteriskCount);
                for (int i = 0; i < cases.Count; i++)
                {
                    int asteriskPointer = 0;
                    string interpolationString = "";
                    for (int j = 0; j < row.Length; j++)
                    {
                        if (row[j] == '*')
                        {
                            interpolationString += cases[i][asteriskPointer];
                            asteriskPointer++;
                        }
                        else
                        {
                            interpolationString += row[j];
                        }
                    }
                    replacedRows.Add(interpolationString);
                }
            }
            return replacedRows;

        }
        //public bool ValidateSimplifiedRow(string row)
        //{
        //    bool valid = true;
        //    // Get the false / true rows from the original table
        //    List<TruthRow> initialRows = _table.Where(row => row.Result == true).ToList();
        //    List<string> verificationRows = GenerateVerificationRows(row);
        //    for (int j = 0; j < verificationRows.Count; j++)
        //    {
        //        if (!initialRows.Contains(new TruthRow(verificationRows[j], true)))
        //        {
        //            valid = false;
        //            break;
        //        }
        //    }
        //    return valid;
        //}
        public bool ValidateSimplifiedTable(List<TruthRow> simplifiedTable)
        {
            bool valid = true;
            for (int i = 0; i < simplifiedTable.Count; i++)
            {
                // Get the false / true rows from the original table
                List<TruthRow> initialRows = _table.Where(row => row.Result == simplifiedTable[i].Result).ToList();
                List<string> verificationRows = GenerateVerificationRows(simplifiedTable[i].BinaryCase);
                for (int j = 0; j < verificationRows.Count; j++)
                {
                    if (!initialRows.Contains(new TruthRow(verificationRows[j], simplifiedTable[i].Result)))
                    {
                        valid = false;
                        break;
                    }
                }
            }
            return valid;
        }
        public PropTree DNF()
        {
            string normalized = "";
            List<char> uniqueVariables = _tree.GetUniqueVariables();
            // Contradiction
            if (_trueRows.Count == 0)
            {
                normalized = "(0)";
            }
            for (int i = 0; i < _trueRows.Count; i++)
            {
                // If there is a subsequent row
                if (i < _trueRows.Count - 1) normalized += "|(";
                for (int j = 0; j < _trueRows[i].BinaryCase.Length; j++)
                {
                    // If there is a subsequent variable
                    if (j < _trueRows[i].BinaryCase.Length - 1) normalized += "&(";
                    if (_trueRows[i].BinaryCase[j] == '0') normalized += "~(";
                    normalized += uniqueVariables[j];
                    if (_trueRows[i].BinaryCase[j] == '0') normalized += ")";
                    // If there is a subsequent variable
                    if (j < _trueRows[i].BinaryCase.Length - 1) normalized += ",";
                    // Add missing closing parentheses
                    else normalized += new string(')', _trueRows[i].BinaryCase.Length - 1);
                }
                // If there is a subsequent row
                if (i < _trueRows.Count - 1) normalized += "),";
            }
            return new PropTree(normalized);
        }

        public PropTree DNFSimplified()
        {
            string normalized = "";
            List<char> uniqueVariables = _tree.GetUniqueVariables();
            List<TruthRow> simplifiedTrueRows = _simplifiedTable.Where(row => row.Result == true).ToList();
            // Contradiction
            if (simplifiedTrueRows.Count == 0)
            {
                normalized = "(0)";
            }
            // Tautology
            if (simplifiedTrueRows.Count == 1 && simplifiedTrueRows.GroupBy(row => row.BinaryCase == "*").Count() == 1)
            {
                normalized = "(1)";
            }
            else
            {
                for (int i = 0; i < simplifiedTrueRows.Count; i++)
                {
                    if (i < simplifiedTrueRows.Count - 1) normalized += "|(";
                    // Skipped parantheses
                    int asteriskCount = StringHandler.CountCharWithValue(simplifiedTrueRows[i].BinaryCase, '*');
                    for (int j = 0; j < simplifiedTrueRows[i].BinaryCase.Length; j++)
                    {
                        // Skip *
                        if (!(simplifiedTrueRows[i].BinaryCase[j] == '*'))
                        {
                            // If there is a subsequent variable
                            if (j < simplifiedTrueRows[i].BinaryCase.Length - 1 &&
                                StringHandler.HasSubsequentChar(simplifiedTrueRows[i].BinaryCase.Substring(j + 1), '1') ||
                                StringHandler.HasSubsequentChar(simplifiedTrueRows[i].BinaryCase.Substring(j + 1), '0')) normalized += "&(";

                            if (simplifiedTrueRows[i].BinaryCase[j] == '0') normalized += "~(";

                            normalized += uniqueVariables[j];
                            if (simplifiedTrueRows[i].BinaryCase[j] == '0') normalized += ")";

                            if (j < simplifiedTrueRows[i].BinaryCase.Length - 1 &&
                                StringHandler.HasSubsequentChar(simplifiedTrueRows[i].BinaryCase.Substring(j + 1), '1') ||
                                StringHandler.HasSubsequentChar(simplifiedTrueRows[i].BinaryCase.Substring(j + 1), '0')) normalized += ",";

                            // Add missing closing parentheses
                            else normalized += new string(')', _trueRows[i].BinaryCase.Length - 1 - asteriskCount);
                        }
                    }
                    // If there is a subsequent row
                    if (i < simplifiedTrueRows.Count - 1) normalized += "),";
                }
            }
            return new PropTree(normalized);
        }
    }
}
