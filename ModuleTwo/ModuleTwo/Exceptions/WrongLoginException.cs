using System;

namespace ModuleTwo.Exceptions
{
    public class WrongLoginException : Exception
    {
        public WrongLoginException(string message)
            : base(message)
        {
        }
    }
}
