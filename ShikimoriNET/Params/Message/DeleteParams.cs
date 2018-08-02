using RestSharp;

namespace ShikimoriNET.Params.Message
{
    public class DeleteParams : IParams
    {
        public int Id { get; set; }

        public IRestRequest GetRequest()
        {
            return new RestRequest("{id}", Method.DELETE).AddUrlSegment("id", Id.ToString());
        }
    }
}