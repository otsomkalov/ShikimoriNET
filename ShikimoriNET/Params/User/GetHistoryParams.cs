using RestSharp;

namespace ShikimoriNET.Params.User
{
    public class GetHistoryParams : IParams
    {
        public int Id { get; set; }

        public IRestRequest GetRequest()
        {
            return new RestRequest("{id}/history").AddUrlSegment("id", Id.ToString());
        }
    }
}