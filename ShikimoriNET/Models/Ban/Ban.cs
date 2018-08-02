using System;
using ShikimoriNET.Models.Shared;

namespace ShikimoriNET.Models.Ban
{
    public class Ban : BaseEntity
    {
        public int UserId { get; set; }
        public string Comment { get; set; }
        public int ModeratorId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int DurationMinutes { get; set; }
        public User.User User { get; set; }
        public User.User Moderator { get; set; }
    }
}