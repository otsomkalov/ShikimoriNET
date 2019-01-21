using System.Collections.Generic;
using ShikimoriNET.Enums.Anime;
using ShikimoriNET.Models.Shared;

namespace ShikimoriNET.Models.Anime
{
    public class FullAnime : FullTitle
    {
        public Kind? Kind { get; set; }
        public int Episodes { get; set; }
        public int EpisodesAired { get; set; }
        public string Rating { get; set; }
        public int Duration { get; set; }
        public IEnumerable<Genre> Studios { get; set; }
        public IEnumerable<Video.Video> Videos { get; set; }
        public IEnumerable<Screenshot> Screenshots { get; set; }
    }
}