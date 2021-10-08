using System.Collections.Generic;

namespace logic_engineering
{
    public class Implication : PropNode
    {
        public Implication()
        {
            this.Value = '>';
        }

        public override bool Evaluate(Dictionary<char, bool> cases)
        {
            bool left = Left.Evaluate(cases);
            bool right = Right.Evaluate(cases);
            // Switcheroo-1 law
            return !left || right;
        }

        public override string Nandify()
        {
            string nand = $"%({Left.Nandify()},%({Right.Nandify()},{Right.Nandify()}))";
            return nand;
        }
    }
}
