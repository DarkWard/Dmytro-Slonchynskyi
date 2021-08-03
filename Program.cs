using System;

namespace TwoLinkedList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var list2 = new TwoLinkedList();

            list2.Add(2);
            list2.Add(7);
            list2.Add(2);
            list2.Add(5);
            list2.Add(4);
            list2[2] = 14;
            list2.AddToEnd(23);
            list2.AddToBegin(39);
            list2.DeleteByIndex(2);
            list2.DeleteByValue(2);

            Console.WriteLine(list2.IndexOf(14));
            Console.WriteLine("\n\n");

            foreach (var i in list2.ToArray())
            {
                Console.WriteLine(i);
            }
        }
    }
}