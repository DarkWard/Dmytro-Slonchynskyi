using System;
using System.Collections.Concurrent;

namespace HomeTask_3_6
{
    public class Subscriber
    {
        private const bool V = true;
        private readonly ConcurrentQueue<int> _queue;

        public Subscriber(ConcurrentQueue<int> queue)
        {
            _queue = queue;
        }

        public void Write()
        {
            while (true)
            {
                if (!_queue.IsEmpty)
                {
                    int val = 0;
                    _queue.TryDequeue(out val);
                    Console.WriteLine(val);
                }
            }
        }
    }
}