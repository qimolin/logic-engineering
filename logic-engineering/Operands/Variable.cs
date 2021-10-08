using System.Collections.Generic;

namespace logic_engineering
{
    public class Variable : PropNode
    {
        public Variable(char variable)
        {
            this.Value = variable;
        }

        public override bool Evaluate(Dictionary<char, bool> cases)
        {
            return cases[Value];
        }

        public override string Nandify()
        {
            return Value.ToString();
        }
    }
}
