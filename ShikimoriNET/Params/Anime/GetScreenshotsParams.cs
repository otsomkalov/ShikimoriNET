using RestSharp;

namespace ShikimoriNET.Params.Anime
{
    public class GetScreenshotsParams : IParams
    {
        public int Id { get; set; }

        public virtual IRestRequest GetRequest()
        {
            return new RestRequest("{id}/screenshots").AddUrlSegment("id", Id.ToString());
        }
    }
}