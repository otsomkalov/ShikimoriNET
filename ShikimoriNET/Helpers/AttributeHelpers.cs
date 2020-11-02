using System.ComponentModel;
using System.Linq;
using ShikimoriNET.Attributes;

namespace ShikimoriNET.Helpers
{
    public static class AttributeHelpers
    {
        public static string GetParamAttributeData<T>(T value)
        {
            if (value == null)
            {
                return null;
            }
        
            var type = value.GetType();
            var field = type.GetField(value.ToString());
            var attributes = field.GetCustomAttributes(typeof(ParamValueAttribute), false) as ParamValueAttribute[];

            return attributes?.FirstOrDefault()?.Value;
        }

        public static string GetDescriptionAttributeData<T>(T value)
        {
            if (value == null)
            {
                return null;
            }
            
            var type = value.GetType();
            var field = type.GetField(value.ToString());
            var attributes = field.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];
            
            return attributes?.FirstOrDefault()?.Description;
        }
    }
}