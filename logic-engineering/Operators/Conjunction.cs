using System.Collections.Generic;

namespace logic_engineering
{
    public class Conjunction : PropNode
    {
        public Conjunction()
        {
            this.Value = '&';
        }
        public override bool Evaluate(Dictionary<char, bool> cases)
        {
            bool left = Left.Evaluate(cases);
            bool right = Right.Evaluate(cases);
            return left && right;
        }

        public override string Nandify()
        {
            string nand = $"%(%({Left.Nandify()},{Right.Nandify()}),%({Left.Nandify()},{Right.Nandify()}))";
            return nand;
        }
    }
}
