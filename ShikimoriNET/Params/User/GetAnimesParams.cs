using RestSharp;

namespace ShikimoriNET.Params.User
{
    public class GetAnimesParams : IParams
    {
        public int Id { get; set; }

        public IRestRequest GetRequest()
        {
            return new RestRequest("{id}/anime_rates").AddUrlSegment("id", Id.ToString());
        }
    }
}