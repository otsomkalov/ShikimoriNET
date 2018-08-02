using RestSharp;

namespace ShikimoriNET.Params.Manga
{
    public class GetFranchiseParams : IParams
    {
        public int Id { get; set; }

        public virtual IRestRequest GetRequest()
        {
            return new RestRequest("{id}/franchise").AddUrlSegment("id", Id.ToString());
        }
    }
}