namespace Nodes
{
    public class Node
    {
        public double Value {  get; set; }

        public Node Left { get; set; }

        public Node Right { get; set; }

        public Node(double value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
}
