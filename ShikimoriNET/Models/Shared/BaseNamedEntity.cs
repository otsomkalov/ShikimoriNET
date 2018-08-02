namespace ShikimoriNET.Models.Shared
{
    public class BaseNamedEntity : BaseEntity
    {
        public string Name { get; set; }
        public string Russian { get; set; }
        public TitleImage Image { get; set; }
        public string Url { get; set; }
    }
}