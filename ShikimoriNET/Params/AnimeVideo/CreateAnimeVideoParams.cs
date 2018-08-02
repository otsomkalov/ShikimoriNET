using System;
using RestSharp;
using ShikimoriNET.Enums.AnimeVideo;

namespace ShikimoriNET.Params.AnimeVideo
{
    public class CreateAnimeVideoParams : IParams
    {
        public int AnimeId { get; set; }
        public string AuthorName { get; set; }
        public int Episode { get; set; }
        public Kind? Kind { get; set; }
        public Language? Language { get; set; }
        public Quality? Quality { get; set; }
        public Uri Source { get; set; }
        public Uri Url { get; set; }

        public virtual IRestRequest GetRequest()
        {
            return new RestRequest("{anime_id}/anime_videos", Method.POST)
                .AddUrlSegment("anime_id", AnimeId)
                .AddBody(this);
        }
    }
}