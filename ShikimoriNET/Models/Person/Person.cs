using ShikimoriNET.Models.Shared;

namespace ShikimoriNET.Models.Person
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }
        public string Russian { get; set; }
        public TitleImage TitleImage { get; set; }
        public string Url { get; set; }
    }
}