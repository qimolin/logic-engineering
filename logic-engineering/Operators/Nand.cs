using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic_engineering.Operators
{
    public class Nand : PropNode
    {
        public Nand()
        {
            this.Value = '%';
        }
        public override bool Evaluate(Dictionary<char, bool> cases)
        {
            bool left = Left.Evaluate(cases);
            bool right = Right.Evaluate(cases);
            return !(left && right);
        }

        public override string Nandify()
        {
            return "";
        }
    }
}
