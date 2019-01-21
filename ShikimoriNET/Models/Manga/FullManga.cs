using ShikimoriNET.Enums.Manga;
using ShikimoriNET.Models.Shared;

namespace ShikimoriNET.Models.Manga
{
    public class FullManga : FullBookTitle
    {
        public Kind? Kind { get; set; }
        public int Volumes { get; set; }
        public int Chapters { get; set; }
    }
}