using RestSharp;

namespace ShikimoriNET.Params.Anime
{
    public class GetRelatedParams : IParams
    {
        public int Id { get; set; }

        public virtual IRestRequest GetRequest()
        {
            return new RestRequest("{id}/similar").AddUrlSegment("id", Id.ToString());
        }
    }
}