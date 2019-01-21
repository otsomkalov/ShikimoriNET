using ShikimoriNET.Enums.Manga;
using ShikimoriNET.Models.Shared;

namespace ShikimoriNET.Models.Manga
{
    public class Manga : BookTitle
    {
        public Kind Kind { get; set; }
    }
}