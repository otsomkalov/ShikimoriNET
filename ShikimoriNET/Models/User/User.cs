using System;
using ShikimoriNET.Models.Shared;

namespace ShikimoriNET.Models.User
{
    public class User : BaseEntity
    {
        public string Nickname { get; set; }
        public Uri Avatar { get; set; }
        public UserImage Image { get; set; }
        public DateTime LastOnlineAt { get; set; }
    }
}