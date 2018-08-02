using System;

namespace ShikimoriNET.Attributes
{
    public class ParamValueAttribute : Attribute
    {
        public ParamValueAttribute(string value)
        {
            Value = value;
        }

        public string Value { get; }
    }
}