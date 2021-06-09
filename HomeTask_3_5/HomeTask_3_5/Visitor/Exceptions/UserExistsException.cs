using System;

namespace HomeTask_3_5.Visitor
{
    public class UserExistsException : Exception
    {
        public UserExistsException(string message)
            : base(message)
        {
        }
    }
}
