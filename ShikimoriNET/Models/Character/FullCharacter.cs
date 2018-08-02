using System;

namespace ShikimoriNET.Models.Character
{
    public class FullCharacter : Character
    {
        public string Altname { get; set; }
        public string Japanese { get; set; }
        public string Description { get; set; }
        public string DescriptionHTML { get; set; }
        public string DescriptionSource { get; set; }
        public bool Favoured { get; set; }
        public int ThreadId { get; set; }
        public int TopicId { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}