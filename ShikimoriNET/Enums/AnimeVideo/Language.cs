using ShikimoriNET.Attributes;

namespace ShikimoriNET.Enums.AnimeVideo
{
    public enum Language
    {
        [ParamValue("russian")] Russian,
        [ParamValue("english")] English,
        [ParamValue("original")] Original,
        [ParamValue("unknown")] Unknown
    }
}