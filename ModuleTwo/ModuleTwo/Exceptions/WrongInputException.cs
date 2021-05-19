using System;

namespace ModuleTwo.Exceptions
{
    public class WrongInputException : Exception
    {
        public WrongInputException(string message)
            : base(message)
        {
        }
    }
}
