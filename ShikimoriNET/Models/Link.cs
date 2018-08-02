namespace ShikimoriNET.Models
{
    public class Link
    {
        public int SourceId { get; set; }
        public int TargetId { get; set; }
        public int Source { get; set; }
        public int Target { get; set; }
        public int Weight { get; set; }
        public string Relation { get; set; }
    }
}