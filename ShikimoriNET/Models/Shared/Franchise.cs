using System.Collections.Generic;

namespace ShikimoriNET.Models.Shared
{
    public class Franchise
    {
        public IEnumerable<Link> Links { get; set; }
        public IEnumerable<Node> Nodes { get; set; }
    }
}