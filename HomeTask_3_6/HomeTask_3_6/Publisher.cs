using System;
using System.Collections.Concurrent;

namespace HomeTask_3_6
{
    public class Publisher
    {
        public event EventHandler<CustomEventArgs> EHandler;

        public void Publish(ConcurrentQueue<int> queue)
        {
            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(new Random().Next());
            }

            EventRaiser(new CustomEventArgs(queue));
        }

        public void EventRaiser(CustomEventArgs e)
        {
            var eve = EHandler;

            if (EHandler != null)
            {
                EHandler(this, e);
            }
        }
    }
}
