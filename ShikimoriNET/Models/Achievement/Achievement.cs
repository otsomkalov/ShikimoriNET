using System;
using ShikimoriNET.Models.Shared;

namespace ShikimoriNET.Models.Achievement
{
    public class Achievement : BaseEntity
    {
        public string NekoId { get; set; }
        public int Level { get; set; }
        public int Progress { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}