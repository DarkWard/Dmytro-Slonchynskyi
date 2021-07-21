namespace TwoLinkedList
{
    internal class TwoLinkedNode : Node
    {
        public TwoLinkedNode(object data)
            : base(data)
        {
        }

        public new TwoLinkedNode Next { get; set; }
        public TwoLinkedNode Prev { get; set; }
    }
}