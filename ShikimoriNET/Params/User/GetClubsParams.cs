using RestSharp;

namespace ShikimoriNET.Params.User
{
    public class GetClubsParams : IParams
    {
        public int Id { get; set; }

        public IRestRequest GetRequest()
        {
            return new RestRequest("{id}/clubs").AddUrlSegment("id", Id.ToString());
        }
    }
}