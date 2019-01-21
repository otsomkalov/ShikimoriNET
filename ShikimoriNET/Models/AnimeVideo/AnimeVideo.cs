using System;
using ShikimoriNET.Enums.AnimeVideo;
using ShikimoriNET.Models.Shared;

namespace ShikimoriNET.Models.AnimeVideo
{
    public class AnimeVideo : BaseEntity
    {
        public int AnimeId { get; set; }
        public Uri Url { get; set; }
        public Uri Source { get; set; }
        public int Episode { get; set; }
        public Kind Kind { get; set; }
        public Language Language { get; set; }
        public Quality Quality { get; set; }
        public string State { get; set; }
        public string AuthorName { get; set; }
    }
}