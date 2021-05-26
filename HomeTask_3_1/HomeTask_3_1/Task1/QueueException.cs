using System;

namespace HomeTask_3_1.Task1
{
    public class QueueException : Exception
    {
        public QueueException(string message)
            : base(message)
        {
        }
    }
}
