using System;

namespace ModuleTwo.Exceptions
{
    public class WrongPasswordException : Exception
    {
        public WrongPasswordException(string message)
            : base(message)
        {
        }
    }
}
