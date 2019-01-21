using System.Collections.Generic;

namespace ShikimoriNET.Models.Shared
{
    public class FullTitle : ItemWithDescription
    {
        public IEnumerable<string> English { get; set; }
        public IEnumerable<string> Japanese { get; set; }
        public IEnumerable<string> Synonyms { get; set; }
        public decimal Score { get; set; }
        public string Franchise { get; set; }
        public bool Anons { get; set; }
        public bool Ongoing { get; set; }
        public int MyAnimeListId { get; set; }
        public IEnumerable<Rate> RatesScroresStats { get; set; }
        public IEnumerable<Status> RatesStatusesStats { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public decimal UserRate { get; set; }
    }
}