using RestSharp;

namespace ShikimoriNET.Params.Friend
{
    public class CreateParams : IParams
    {
        public string Id { get; set; }

        public IRestRequest GetRequest()
        {
            return new RestRequest("{id}", Method.POST).AddUrlSegment("id", Id);
        }
    }
}