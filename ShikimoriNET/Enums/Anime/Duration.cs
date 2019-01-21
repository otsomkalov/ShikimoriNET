using ShikimoriNET.Attributes;

namespace ShikimoriNET.Enums.Anime
{
    public enum Duration
    {
        /// <summary>
        ///     Меньше 10 минут
        /// </summary>
        [ParamValue("S")] S,

        /// <summary>
        ///     Меньше 30 минут
        /// </summary>
        [ParamValue("D")] D,

        /// <summary>
        ///     Больше 30 минут
        /// </summary>
        [ParamValue("F")] F
    }
}