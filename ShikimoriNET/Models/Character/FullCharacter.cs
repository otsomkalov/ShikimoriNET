using System;

namespace ShikimoriNET.Models.Character
{
    public class FullCharacter : Character
    {
        public string Altname { get; set; }
        public string Japanese { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}