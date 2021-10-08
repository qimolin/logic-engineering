using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic_engineering.Operands
{
    public class TrueNode : PropNode
    {
        public TrueNode()
        {
            this.Value = '1';
        }
        public override bool Evaluate(Dictionary<char, bool> cases)
        {
            return true;
        }

        public override string Nandify()
        {
            return "(1)";
        }
    }
}
