using ShikimoriNET.Enums.Anime;
using ShikimoriNET.Models.Shared;

namespace ShikimoriNET.Models.Anime
{
    public class Anime : Title
    {
        public Kind? Kind { get; set; }
        public int Episodes { get; set; }
        public int EpisodesAired { get; set; }
    }
}