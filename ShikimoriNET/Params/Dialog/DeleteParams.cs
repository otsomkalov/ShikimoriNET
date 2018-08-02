using RestSharp;

namespace ShikimoriNET.Params.Dialog
{
    public class DeleteParams : IParams
    {
        public string Id { get; set; }

        public virtual IRestRequest GetRequest()
        {
            return new RestRequest("{id}", Method.DELETE).AddUrlSegment("id", Id);
        }
    }
}