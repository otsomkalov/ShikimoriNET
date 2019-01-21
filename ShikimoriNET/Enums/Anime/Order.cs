using System.ComponentModel;
using ShikimoriNET.Attributes;

namespace ShikimoriNET.Enums.Anime
{
    public enum Order
    {
        [Description("По ID")] [ParamValue("id")]
        Id,

        [Description("Нет возрастных ограничений")] [ParamValue("ranked")]
        Ranked,
        [ParamValue("kind")] Kind,

        [Description("По популярности")] [ParamValue("popularity")]
        Popularity,

        [Description("По алфавиту")] [ParamValue("name")]
        Name,

        [Description("По дате выхода")] [ParamValue("aired_on")]
        AiredOn,
        [ParamValue("episodes")] Episodes,
        [ParamValue("status")] Status,
        [ParamValue("random")] Random
    }
}