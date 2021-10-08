using System.Collections.Generic;

namespace logic_engineering
{
    public class Negation : PropNode
    {
        public Negation()
        {
            this.Value = '~';
        }
        public override bool Evaluate(Dictionary<char, bool> cases)
        {
            bool right = Right.Evaluate(cases);
            return !right;
        }

        public override string Nandify()
        {
            string nand = $"%({Right.Nandify()},{Right.Nandify()})";
            return nand;
        }
    }
}
