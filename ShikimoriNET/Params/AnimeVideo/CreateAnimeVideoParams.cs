using RestSharp;

namespace ShikimoriNET.Params.AnimeVideo
{
    public class CreateAnimeVideoParams : IParams
    {
        public AnimeVideo AnimeVideo { get; set; }

        public virtual IRestRequest GetRequest()
        {
            return new RestRequest("{anime_id}/anime_videos", Method.POST)
                .AddUrlSegment("anime_id", AnimeVideo.AnimeId)
                .AddBody(this);
        }
    }
}