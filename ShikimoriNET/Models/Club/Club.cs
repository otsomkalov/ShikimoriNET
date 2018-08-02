using ShikimoriNET.Models.Shared;

namespace ShikimoriNET.Models.Club
{
    public class Club : BaseEntity
    {
        public string Name { get; set; }
        public Image Logo { get; set; }
        public bool IsCensored { get; set; }
        public string JoinPolicy { get; set; }
        public string CommentPolice { get; set; }
    }
}