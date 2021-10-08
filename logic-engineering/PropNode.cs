using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic_engineering
{
    public abstract class PropNode
    {
        public string Name { get; set; }
        public char Value { get; set; }
        public PropNode Left { get; set; }
        public PropNode Right { get; set; }

        public abstract bool Evaluate(Dictionary<char, bool> cases);
        public abstract string Nandify();
        public override bool Equals(object obj)
        {
            return obj is PropNode node &&
                   Value == node.Value &&
                   EqualityComparer<PropNode>.Default.Equals(Left, node.Left) &&
                   EqualityComparer<PropNode>.Default.Equals(Right, node.Right);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Value, Left, Right);
        }
    }
}
