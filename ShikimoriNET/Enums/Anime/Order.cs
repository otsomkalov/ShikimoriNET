using ShikimoriNET.Attributes;

namespace ShikimoriNET.Enums.Anime
{
    public enum Order
    {
        [ParamValue("id")] Id,
        [ParamValue("ranked")] Ranked,
        [ParamValue("kind")] Kind,
        [ParamValue("popularity")] Popularity,
        [ParamValue("name")] Name,
        [ParamValue("aired_on")] AiredOn,
        [ParamValue("episodes")] Episodes,
        [ParamValue("status")] Status,
        [ParamValue("random")] Random
    }
}