using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic_engineering
{
    public class TruthRow
    {
        public bool Result { get; private set; }
        public string[] FullRow { get; set; }
        public string BinaryCase { get; set; }
        public bool Valid { get; set; } // Used for simplification
        public TruthRow(string binaryCase, bool result)
        {
            Valid = true;
            BinaryCase = binaryCase;
            Result = result;
            FullRow = new string[BinaryCase.Length + 1];
            for (int i = 0; i < BinaryCase.Length; i++)
            {
                FullRow[i] = BinaryCase[i].ToString();
            }
            FullRow[BinaryCase.Length] = Result ? "1" : "0";
        }

        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if (!(obj is TruthRow)) return false;
            TruthRow row = (TruthRow)obj;
            bool fullRowEqual = false;
            for (int i = 0; i < FullRow.Length; i++)
            {
                if (row.FullRow[i] == FullRow[i])
                    fullRowEqual = true;
                else fullRowEqual = false;
            }
            return Result == row.Result &&
                   fullRowEqual &&
                   BinaryCase == row.BinaryCase;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Result, BinaryCase);
        }
    }
}
