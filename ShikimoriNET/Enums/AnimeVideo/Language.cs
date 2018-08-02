using System.ComponentModel;
using ShikimoriNET.Attributes;

namespace ShikimoriNET.Enums.AnimeVideo
{
    public enum Language //TODO: Change description
    {
        [Description("Манга")] [ParamValue("russian")]
        Russian,

        [Description("Манхва")] [ParamValue("english")]
        English,

        [Description("OVA")] [ParamValue("original")]
        Original,

        [Description("ONA")] [ParamValue("unknown")]
        Unknown
    }
}