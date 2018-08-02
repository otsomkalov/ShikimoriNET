using System;

namespace ShikimoriNET.Models.Shared
{
    public class ExternalLink : BaseEntity
    {
        public string Kind { get; set; }
        public Uri Url { get; set; }
        public string Source { get; set; }
        public int EntryId { get; set; }
        public string EntryType { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? ImportedAt { get; set; }
    }
}