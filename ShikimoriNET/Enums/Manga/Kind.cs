using ShikimoriNET.Attributes;

namespace ShikimoriNET.Enums.Manga
{
    public enum Kind
    {
        [ParamValue("manga")] Manga,
        [ParamValue("manhwa")] Manhwa,
        [ParamValue("manhua")] Manhua,
        [ParamValue("novel")] Novel,
        [ParamValue("one_shot")] OneShot,
        [ParamValue("doujin")] Doujin
    }
}