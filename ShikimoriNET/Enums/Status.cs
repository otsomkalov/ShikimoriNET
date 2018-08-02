using ShikimoriNET.Attributes;

namespace ShikimoriNET.Enums
{
    public enum Status
    {
        [ParamValue("anons")] Anons,

        [ParamValue("ongoing")] Ongoing,

        [ParamValue("released")] Released
    }
}