namespace ShikimoriNET.Models.Shared
{
    public class ItemWithDescription : Title
    {
        public string Description { get; set; }
        public string DescriptionHTML { get; set; }
        public string DescriptionSource { get; set; }
        public bool Favoured { get; set; }
        public int ThreadId { get; set; }
        public int TopicId { get; set; }
    }
}