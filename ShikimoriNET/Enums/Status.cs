using System.ComponentModel;
using ShikimoriNET.Attributes;

namespace ShikimoriNET.Enums
{
    public enum Status
    {
        [Description("Анонсировано")] [ParamValue("anons")]
        Anons,

        [Description("Онгоинг")] [ParamValue("ongoing")]
        Ongoing,

        [Description("Выпущено")] [ParamValue("released")]
        Released
    }
}