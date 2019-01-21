using ShikimoriNET.Attributes;

namespace ShikimoriNET.Enums.AnimeVideo
{
    public enum Kind
    {
        [ParamValue("raw")] Raw,
        [ParamValue("subtitles")] Subtitles,
        [ParamValue("fandub")] Fundub,
        [ParamValue("unknown")] Unknown
    }
}