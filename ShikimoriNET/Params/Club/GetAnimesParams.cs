using RestSharp;

namespace ShikimoriNET.Params.Club
{
    public class GetAnimesParams : IParams
    {
        public int Id { get; set; }

        public virtual IRestRequest GetRequest()
        {
            return new RestRequest("{id}/animes").AddUrlSegment("id", Id.ToString());
        }
    }
}