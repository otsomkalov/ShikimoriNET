using System.Collections.Generic;

namespace ShikimoriNET.Models.Shared
{
    public class FullBookTitle : FullTitle
    {
        public IEnumerable<string> Publishers { get; set; }
    }
}