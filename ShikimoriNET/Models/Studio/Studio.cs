using ShikimoriNET.Models.Shared;

namespace ShikimoriNET.Models.Studio
{
    public class Studio : BaseEntity
    {
        public string Name { get; set; }
        public string FilteredName { get; set; }
        public bool Read { get; set; }
        public string Image { get; set; }
    }
}