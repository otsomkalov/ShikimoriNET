using System.ComponentModel;
using ShikimoriNET.Attributes;

namespace ShikimoriNET.Enums.AnimeVideo
{
    public enum Kind //TODO: Change description
    {
        [Description("Манга")] [ParamValue("raw")]
        Raw,

        [Description("Манхва")] [ParamValue("subtitles")]
        Subtitles,

        [Description("OVA")] [ParamValue("fandub")]
        Fundub,

        [Description("ONA")] [ParamValue("unknown")]
        Unknown
    }
}