using ShikimoriNET.Attributes;

namespace ShikimoriNET.Enums.Comment
{
    public enum Kind
    {
        [ParamValue("topic")] Topic,
        [ParamValue("user")] User
    }
}