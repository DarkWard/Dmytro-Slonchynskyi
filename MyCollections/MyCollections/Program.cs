namespace MyCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            RefList list = new RefList();

            list.Add(2);
            list.Add(7);
            list.Add(2);
            list.Add(5);
            list.AddToEnd(9);
            list.Add(4);
            list.Add(8);
        }
    }
}
