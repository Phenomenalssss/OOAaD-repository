using INodes;

namespace Nodes
{
    public class Node : INode
    {
        public double Value {  get; set; }

        public INode Left { get; set; }

        public INode Right { get; set; }

        public Node(double value, INode left, INode right)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }
}
