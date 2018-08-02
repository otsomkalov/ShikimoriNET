using RestSharp;

namespace ShikimoriNET.Params.User
{
    public class GetMangasParams : IParams
    {
        public int Id { get; set; }

        public IRestRequest GetRequest()
        {
            return new RestRequest("{id}/manga_rates").AddUrlSegment("id", Id.ToString());
        }
    }
}