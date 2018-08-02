using System.Collections.Generic;
using ShikimoriNET.Models.Shared;

namespace ShikimoriNET.Models.Anime
{
    public class FullAnime : Anime
    {
        public string Rating { get; set; }
        public IEnumerable<string> English { get; set; }
        public IEnumerable<string> Japanese { get; set; }
        public IEnumerable<string> Synonyms { get; set; }
        public int Duration { get; set; }
        public decimal Score { get; set; }
        public string Description { get; set; }
        public string DescriptionHTML { get; set; }
        public string DescriptionSource { get; set; }
        public string Franchise { get; set; }
        public bool Favoured { get; set; }
        public bool? Anons { get; set; }
        public bool? Ongoing { get; set; }
        public int ThreadId { get; set; }
        public int TopicId { get; set; }
        public int MyAnimeListId { get; set; }
        public IEnumerable<Rate> RatesScroresStats { get; set; }
        public IEnumerable<Status> RatesStatusesStats { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public IEnumerable<Genre> Studios { get; set; }
    }
}