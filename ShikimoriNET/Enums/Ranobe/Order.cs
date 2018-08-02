using ShikimoriNET.Attributes;

namespace ShikimoriNET.Enums.Ranobe
{
    public enum Order
    {
        [ParamValue("id")] Id,
        [ParamValue("ranked")] Ranked,
        [ParamValue("kind")] Kind,
        [ParamValue("popularity")] Popularity,
        [ParamValue("name")] Name,
        [ParamValue("aired_on")] AiredOn,
        [ParamValue("volumes")] Volumes,
        [ParamValue("chapters")] Chapters,
        [ParamValue("status")] Status,
        [ParamValue("random")] Random
    }
}