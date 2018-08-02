using System;

namespace ShikimoriNET.Models.Shared
{
    public class Node : BaseEntity
    {
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public Uri ImageUrl { get; set; }
        public string Url { get; set; }
        public string Year { get; set; }
        public string Kind { get; set; }
        public int Weight { get; set; }
    }
}