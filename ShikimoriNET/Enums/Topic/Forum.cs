using ShikimoriNET.Attributes;

namespace ShikimoriNET.Enums.Topic
{
    public enum Forum
    {
        [ParamValue("all")]
        All,
        [ParamValue("offtopic")]
        Offtopic,
        [ParamValue("animanga")]
        Animanga,
        [ParamValue("site")]
        Site,
        [ParamValue("games")]
        Games,
        [ParamValue("vn")]
        VisualNovels,
        [ParamValue("contests")]
        Contests,
        [ParamValue("clubs")]
        Clubs,
        [ParamValue("my_clubs")]
        MyClubs,
        [ParamValue("reviews")]
        Reviews,
        [ParamValue("news")]
        News,
        [ParamValue("collections")]
        Collections,
        [ParamValue("cosplay")]
        Cosplay
    }
}