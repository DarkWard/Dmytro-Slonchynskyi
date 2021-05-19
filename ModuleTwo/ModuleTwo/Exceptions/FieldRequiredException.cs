using System;

namespace ModuleTwo.Exceptions
{
    public class FieldRequiredException : Exception
    {
        public FieldRequiredException(string fieldName, string message)
            : base(message)
        {
            FieldName = fieldName;
        }

        public string FieldName { get; }
    }
}
