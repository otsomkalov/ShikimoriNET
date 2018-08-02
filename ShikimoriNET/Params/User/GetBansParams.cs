using RestSharp;

namespace ShikimoriNET.Params.User
{
    public class GetBansParams : IParams
    {
        public int Id { get; set; }

        public IRestRequest GetRequest()
        {
            return new RestRequest("{id}/bans").AddUrlSegment("id", Id.ToString());
        }
    }
}