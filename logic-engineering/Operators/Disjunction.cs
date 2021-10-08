﻿using System.Collections.Generic;

namespace logic_engineering
{
    public class Disjunction : PropNode
    {
        public Disjunction()
        {
            this.Value = '|';
        }
        public override bool Evaluate(Dictionary<char, bool> cases)
        {
            bool left = Left.Evaluate(cases);
            bool right = Right.Evaluate(cases);
            return left || right;
        }

        public override string Nandify()
        {
            string nand = $"%(%({Left.Nandify()},{Left.Nandify()}),%({Right.Nandify()},{Right.Nandify()}))";
            return nand;
        }
    }
}
