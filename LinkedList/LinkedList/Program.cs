using System;

namespace LinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var list = new RefList();

            list.Add(2);
            list.Add(7);
            list.Add(2);
            list.Add(5);
            list.AddToEnd(9);
            list.Add(4);
            list.Add(8);
            list.AddToBegin(3);
            list.DeleteByValue(2);

            Console.WriteLine($"Index of 7: {list.IndexOf(7)}\n___________\n");

            foreach (var i in list.ToArray())
            {
                Console.WriteLine(i);
            }
        }
    }
}