using System;

namespace ModuleTwo.Exceptions
{
    public class UserExistsException : Exception
    {
        public UserExistsException(string message)
            : base(message)
        {
        }
    }
}
