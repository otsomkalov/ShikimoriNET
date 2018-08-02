using ShikimoriNET.Models.Shared;

namespace ShikimoriNET.Models
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }
        public string Russian { get; set; }
        public string Kind { get; set; }
    }
}