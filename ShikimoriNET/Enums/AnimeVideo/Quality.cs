using ShikimoriNET.Attributes;

namespace ShikimoriNET.Enums.AnimeVideo
{
    public enum Quality
    {
        [ParamValue("bd")] BD,
        [ParamValue("web")] Web,
        [ParamValue("tv")] TV,
        [ParamValue("dvd")] DVD,
        [ParamValue("unknown")] Unknown
    }
}