using System;

namespace ModuleTwo
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class RequiredFieldAttribute : Attribute
    {
        public RequiredFieldAttribute()
        {
        }

        public string FieldName { get; set; }
    }
}