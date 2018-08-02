using System;
using ShikimoriNET.Models.Shared;

namespace ShikimoriNET.Enums
{
    public class Title : BaseNamedEntity
    {
        public Status? Status { get; set; }
        public DateTime? AiredOn { get; set; }
        public DateTime? ReleasedOn { get; set; }
    }
}