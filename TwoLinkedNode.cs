namespace TwoLinkedList
{
    internal class TwoLinkedNode : Node
    {
        public TwoLinkedNode(object data)
            : base(data)
        {
        }

        public TwoLinkedNode Prev { get; set; }
    }
}