using System;
using ShikimoriNET.Enums.AnimeVideo;

namespace ShikimoriNET.Params.AnimeVideo
{
    public class AnimeVideo
    {
        public int AnimeId { get; set; }
        public string AuthorName { get; set; }
        public int Episodes { get; set; }
        public Kind Kind { get; set; }
        public Language Language { get; set; }
        public Quality Quality { get; set; }
        public Uri Source { get; set; }
        public Uri Url { get; set; }
    }
}