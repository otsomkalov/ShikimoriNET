using System.ComponentModel;
using ShikimoriNET.Attributes;

namespace ShikimoriNET.Enums.AnimeVideo
{
    public enum Quality //TODO: Change description
    {
        [Description("Манга")] [ParamValue("bd")]
        BD,

        [Description("Манхва")] [ParamValue("web")]
        Web,

        [Description("OVA")] [ParamValue("tv")]
        TV,

        [Description("OVA")] [ParamValue("dvd")]
        DVD,

        [Description("ONA")] [ParamValue("unknown")]
        Unknown
    }
}