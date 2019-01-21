using System;
using ShikimoriNET.Enums.Video;
using ShikimoriNET.Models.Shared;

namespace ShikimoriNET.Models.Video
{
    public class Video : BaseEntity
    {
        public Uri Url { get; set; }
        public Uri ImageUrl { get; set; }
        public Uri PlayerUrl { get; set; }
        public string Name { get; set; }
        public Kind Kind { get; set; }
        public string Hosting { get; set; }
    }
}