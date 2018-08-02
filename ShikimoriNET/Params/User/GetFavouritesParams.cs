using RestSharp;

namespace ShikimoriNET.Params.User
{
    public class GetFavouritesParams : IParams
    {
        public int Id { get; set; }

        public IRestRequest GetRequest()
        {
            return new RestRequest("{id}/clubs").AddUrlSegment("id", Id.ToString());
        }
    }
}