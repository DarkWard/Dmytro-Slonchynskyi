using System;

namespace ModuleTwo.Exceptions
{
    public class MissingUserException : Exception
    {
        public MissingUserException(string message)
            : base(message)
        {
        }
    }
}