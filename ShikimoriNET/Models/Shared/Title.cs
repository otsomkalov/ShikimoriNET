using System;

namespace ShikimoriNET.Models.Shared
{
    public class Title : BaseNamedEntity
    {
        public Enums.Status? Status { get; set; }
        public DateTime? AiredOn { get; set; }
        public DateTime? ReleasedOn { get; set; }
    }
}