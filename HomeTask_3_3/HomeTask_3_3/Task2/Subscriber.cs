using System;

namespace HomeTask_3_3.Task2
{
    public class Subscriber
    {
        private readonly int _id;

        public Subscriber(int id, Publisher pub)
        {
            _id = id;

            pub.EHandler += HandleCustomEvent;
        }

        public void HandleCustomEvent(object sender, EventArgs e)
        {
            Console.WriteLine($"Subscriber №{_id} published at {DateTime.UtcNow}");
        }
    }
}
