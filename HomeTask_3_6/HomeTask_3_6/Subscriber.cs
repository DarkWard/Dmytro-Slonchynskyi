using System;
using System.Threading;

namespace HomeTask_3_6
{
    public class Subscriber
    {
        private readonly int _id;

        public Subscriber(int id, Publisher pub)
        {
            _id = id;

            pub.EHandler += HandleEvent;
        }

        public void HandleEvent(object sender, CustomEventArgs e)
        {
            if (!e.Queue.IsEmpty)
            {
                foreach (var item in e.Queue)
                {
                    Console.WriteLine(item);
                    Thread.Sleep(300);
                }
            }
        }
    }
}