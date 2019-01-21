using System.ComponentModel;
using ShikimoriNET.Attributes;

namespace ShikimoriNET.Enums
{
    public enum Rating
    {
        [ParamValue("none")] None,

        /// <summary>
        ///     Нет возрастных ограничений
        /// </summary>
        [Description("Нет возрастных ограничений")] [ParamValue("g")]
        G,

        /// <summary>
        ///     Рекоммендуется присутствие родителей
        /// </summary>
        [Description("Рекоммендуется присутствие родителей")] [ParamValue("pg")]
        Pg,

        /// <summary>
        ///     Детям до 13 лет просмотр не желателен
        /// </summary>
        [Description("Детям до 13 лет просмотр не желателен")] [ParamValue("pg_13")]
        Pg13,

        /// <summary>
        ///     Лицам до 17 лет обязательно присутствие взрослого
        /// </summary>
        [Description("Лицам до 17 лет обязательно присутствие взрослого")] [ParamValue("r")]
        R,

        /// <summary>
        ///     Лицам до 17 лет просмотр запрещен
        /// </summary>
        [Description("Лицам до 17 лет просмотр запрещен")] [ParamValue("r_plus")]
        RPlus,

        /// <summary>
        ///     Хентай
        /// </summary>
        [Description("Хентай")] [ParamValue("rx")]
        Rx
    }
}