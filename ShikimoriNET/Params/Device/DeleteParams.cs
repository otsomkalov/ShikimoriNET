using RestSharp;

namespace ShikimoriNET.Params.Device
{
    public class DeleteParams : IParams
    {
        public int Id { get; set; }

        public virtual IRestRequest GetRequest()
        {
            return new RestRequest("{id}", Method.DELETE).AddUrlSegment("id", Id.ToString());
        }
    }
}