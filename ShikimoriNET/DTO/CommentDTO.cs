namespace ShikimoriNET.DTO
{
    public class CommentDTO
    {
        public string Body { get; set; }
        public int CommentId { get; set; }
        public string CommentType { get; set; }
        public bool IsOfftopic { get; set; }
        public bool IsSummary { get; set; }
    }
}