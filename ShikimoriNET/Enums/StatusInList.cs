using ShikimoriNET.Attributes;

namespace ShikimoriNET.Enums
{
    public enum StatusInList
    {
        [ParamValue("planned")] Planned,
        [ParamValue("watching")] Watching,
        [ParamValue("rewatching")] ReWatching,
        [ParamValue("completed")] Completed,
        [ParamValue("on_hold")] OnHold,
        [ParamValue("dropped")] Dropped
    }
}