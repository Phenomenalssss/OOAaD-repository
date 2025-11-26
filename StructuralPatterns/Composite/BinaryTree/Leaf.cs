using System;
using System.Collections.Generic;
using System.Text;
using INodes;

namespace Leafs
{
    public class Leaf : INode
    {
        public double Value { get; set; }

        public Leaf(double value)
        {
            Value = value;
        }
    }
}
