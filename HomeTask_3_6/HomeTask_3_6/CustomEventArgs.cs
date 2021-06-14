using System;
using System.Collections.Concurrent;

namespace HomeTask_3_6
{
    public class CustomEventArgs : EventArgs
    {
        public CustomEventArgs(ConcurrentQueue<int> queue)
        {
            Queue = queue;
        }

        public ConcurrentQueue<int> Queue { get; set; }
    }
}
