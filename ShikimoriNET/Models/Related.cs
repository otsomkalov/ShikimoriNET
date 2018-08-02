namespace ShikimoriNET.Models
{
    public class Related
    {
        public string Relation { get; set; }
        public string RelationRussian { get; set; }
        public Anime.Anime Anime { get; set; }
        public Manga.Manga Manga { get; set; }
    }
}