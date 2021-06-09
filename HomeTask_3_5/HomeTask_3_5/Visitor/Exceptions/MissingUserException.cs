using System;

namespace HomeTask_3_5.Visitor
{
    public class MissingUserException : Exception
    {
        public MissingUserException(string message)
            : base(message)
        {
        }
    }
}