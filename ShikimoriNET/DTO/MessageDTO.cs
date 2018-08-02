namespace ShikimoriNET.DTO
{
    public class MessageDTO
    {
        public string Body { get; set; }
        public int FromId { get; set; }
        public string Kind { get; set; }
        public int ToId { get; set; }
    }
}