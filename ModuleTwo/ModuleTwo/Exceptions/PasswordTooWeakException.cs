using System;

namespace ModuleTwo.Exceptions
{
    public class PasswordTooWeakException : Exception
    {
        public PasswordTooWeakException(string message)
            : base(message)
        {
        }
    }
}
