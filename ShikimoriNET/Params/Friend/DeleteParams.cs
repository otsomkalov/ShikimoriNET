using RestSharp;

namespace ShikimoriNET.Params.Friend
{
    public class DeleteParams : IParams
    {
        public string Id { get; set; }

        public IRestRequest GetRequest()
        {
            return new RestRequest("{id}", Method.DELETE).AddUrlSegment("id", Id);
        }
    }
}