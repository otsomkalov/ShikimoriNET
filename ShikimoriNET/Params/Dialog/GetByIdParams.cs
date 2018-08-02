using RestSharp;

namespace ShikimoriNET.Params.Dialog
{
    public class GetByIdParams : IParams
    {
        public string Id { get; set; }

        public virtual IRestRequest GetRequest()
        {
            return new RestRequest("{id}").AddUrlSegment("id", Id);
        }
    }
}