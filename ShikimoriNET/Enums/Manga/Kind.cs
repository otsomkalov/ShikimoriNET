using System.ComponentModel;
using ShikimoriNET.Attributes;

namespace ShikimoriNET.Enums.Manga
{
    public enum Kind //TODO: Change description
    {
        [Description("Манга")] [ParamValue("manga")]
        Manga,

        [Description("Манхва")] [ParamValue("manhwa")]
        Manhwa,

        [Description("OVA")] [ParamValue("manhua")]
        Manhua,

        [Description("ONA")] [ParamValue("novel")]
        Novel,

        [Description("Спешл")] [ParamValue("one_shot")]
        OneShot,

        [Description("Клип")] [ParamValue("doujin")]
        Doujin
    }
}