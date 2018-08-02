using System;

namespace ShikimoriNET.Models.Calendar
{
    public class Event
    {
        public int NextEpisode { get; set; }
        public DateTime NextEpisodeAt { get; set; }
        public string Duration { get; set; }
        public Anime.Anime Anime { get; set; }
    }
}