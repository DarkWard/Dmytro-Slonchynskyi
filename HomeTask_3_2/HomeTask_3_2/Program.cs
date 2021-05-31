using System;
using HomeTask_3_2.Task1;
using HomeTask_3_2.Task2;

namespace HomeTask_3_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var values = new int[] { 1, 2, 5, 28, 3, 17 };
            var list = new ReadonlyDataStore<int>(values);

            Console.WriteLine($"Readonly Data Store:\n{list.Count} items:\n");

            foreach (var item in list.Items)
            {
                Console.WriteLine(item);
            }

            var table = new MyHashTable<int, string>(20);
            table.Add(45, "hello");
            table.Add(18, "world");
            table.Add(45, "and");
            table.Add(4, "everyone");
            table.Add(44, "else");

            Console.WriteLine("My Hash Table:\n");

            Console.WriteLine(table.Find(45));
            Console.WriteLine(table.Find(18));
            Console.WriteLine(table.Find(45));
            Console.WriteLine(table.Find(4));
            Console.WriteLine(table.Find(44));

            Console.WriteLine($"\nTable with removed {table.Find(45)}");

            table.Remove(45);

            Console.WriteLine(table.Find(18));
            Console.WriteLine(table.Find(45));
            Console.WriteLine(table.Find(4));
            Console.WriteLine(table.Find(44));
        }
    }
}