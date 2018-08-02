using RestSharp;

namespace ShikimoriNET.Params.Comment
{
    public class DeleteParams : IParams
    {
        public int Id { get; set; }

        public IRestRequest GetRequest()
        {
            return new RestRequest("{id}").AddUrlSegment("{id}", Id.ToString());
        }
    }
}