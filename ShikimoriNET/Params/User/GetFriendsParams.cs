using RestSharp;

namespace ShikimoriNET.Params.User
{
    public class GetFriendsParams : IParams
    {
        public int Id { get; set; }

        public IRestRequest GetRequest()
        {
            return new RestRequest("{id}/friends").AddUrlSegment("id", Id.ToString());
        }
    }
}