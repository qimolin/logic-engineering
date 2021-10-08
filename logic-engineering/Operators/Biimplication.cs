using System.Collections.Generic;

namespace logic_engineering
{
    public class Biimplication : PropNode
    {
        public Biimplication()
        {
            this.Value = '=';
        }

        public override bool Evaluate(Dictionary<char, bool> cases)
        {
            bool left = Left.Evaluate(cases);
            bool right = Right.Evaluate(cases);
            // Switcheroo-2 law
            return (left && right) || (!left && !right);
        }

        public override string Nandify()
        {
            string nand = $"%(%(%({Left.Nandify()},{Left.Nandify()}),%({Right.Nandify()},{Right.Nandify()})),%({Left.Nandify()},{Right.Nandify()}))";
            return nand;
        }
    }
}
