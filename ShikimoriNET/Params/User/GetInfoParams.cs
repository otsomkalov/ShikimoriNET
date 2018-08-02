using RestSharp;

namespace ShikimoriNET.Params.User
{
    public class GetInfoParams : IParams
    {
        public int Id { get; set; }

        public IRestRequest GetRequest()
        {
            return new RestRequest("{id}/info").AddUrlSegment("id", Id.ToString());
        }
    }
}