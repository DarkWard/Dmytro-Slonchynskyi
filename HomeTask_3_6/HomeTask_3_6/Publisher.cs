using System;
using System.Collections.Concurrent;

namespace HomeTask_3_6
{
    public class Publisher
    {
        public void Publish(ConcurrentQueue<int> queue)
        {
            for (int i = 0; i < 3; i++)
            {
                queue.Enqueue(new Random().Next());
            }
        }
    }
}
