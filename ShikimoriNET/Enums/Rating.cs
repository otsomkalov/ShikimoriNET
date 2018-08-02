using ShikimoriNET.Attributes;

namespace ShikimoriNET.Enums
{
    public enum Rating
    {
        [ParamValue("none")] None,
        [ParamValue("g")] G,
        [ParamValue("pg")] Pg,
        [ParamValue("pg_13")] Pg13,
        [ParamValue("r")] R,
        [ParamValue("r_plus")] RPlus,
        [ParamValue("rx")] Rx
    }
}