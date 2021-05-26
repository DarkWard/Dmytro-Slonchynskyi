using System;
using HomeTask_3_1.Task1;
using HomeTask_3_1.Task2;
using HomeTask_3_1.Task3;

namespace HomeTask_3_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MyQueue<string> queue = new MyQueue<string>();
            queue.Enqueue("One");
            queue.Enqueue("Two");
            queue.Enqueue("Three");
            queue.Enqueue("Four");

            Console.WriteLine("Queue:");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Dequeued item: {queue.Dequeue()}");

            Console.WriteLine("\nResult queue:");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"\nPeeked item: {queue.Peek()}");

            var dataStore = new DataStore<int>();

            dataStore.Add(4);
            dataStore.Add(8);
            dataStore.Add(12);
            dataStore.Add(6);
            dataStore.Add(9);
            dataStore.Add(32);

            Console.WriteLine("Data Store:");

            foreach (var item in dataStore)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nRemoved item: 12");

            dataStore.Remove(12);

            foreach (var item in dataStore)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nWeeks:");

            Week week = new Week();
            foreach (var day in week)
            {
                Console.WriteLine(day);
            }
        }
    }
}
