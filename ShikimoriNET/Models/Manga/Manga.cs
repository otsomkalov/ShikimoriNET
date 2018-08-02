using ShikimoriNET.Enums;
using ShikimoriNET.Enums.Manga;

namespace ShikimoriNET.Models.Manga
{
    public class Manga : Title
    {
        public Kind? Kind { get; set; }
        public int Volumes { get; set; }
        public int Chapters { get; set; }
    }
}