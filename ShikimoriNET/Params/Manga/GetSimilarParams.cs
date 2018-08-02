using RestSharp;

namespace ShikimoriNET.Params.Manga
{
    public class GetSimilarParams : IParams
    {
        public int Id { get; set; }

        public virtual IRestRequest GetRequest()
        {
            return new RestRequest("{id}/similar").AddUrlSegment("id", Id.ToString());
        }
    }
}