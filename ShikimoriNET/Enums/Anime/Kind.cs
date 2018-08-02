using System.ComponentModel;
using ShikimoriNET.Attributes;

namespace ShikimoriNET.Enums.Anime
{
    public enum Kind
    {
        [Description("TV Сериал")] [ParamValue("tv")]
        Tv,

        [Description("Фильм")] [ParamValue("movie")]
        Movie,

        [Description("OVA")] [ParamValue("ova")]
        Ova,

        [Description("ONA")] [ParamValue("ona")]
        Ona,

        [Description("Спешл")] [ParamValue("special")]
        Special,

        [Description("Клип")] [ParamValue("music")]
        Music,
        [ParamValue("tv_13")] Tv13,
        [ParamValue("tv_24")] Tv24,
        [ParamValue("tv_48")] Tv48
    }
}