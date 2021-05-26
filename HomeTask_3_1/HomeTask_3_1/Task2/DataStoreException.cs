using System;

namespace HomeTask_3_1.Task2
{
    public class DataStoreException : Exception
    {
        public DataStoreException(string message)
            : base(message)
        {
        }
    }
}
