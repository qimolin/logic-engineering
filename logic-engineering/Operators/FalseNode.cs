using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic_engineering.Operators
{
    public class FalseNode : PropNode
    {
        public FalseNode()
        {
            this.Value = '1';
        }
        public override bool Evaluate(Dictionary<char, bool> cases)
        {
            return false;
        }

        public override string Nandify()
        {
            return "(0)";
        }
    }
}
