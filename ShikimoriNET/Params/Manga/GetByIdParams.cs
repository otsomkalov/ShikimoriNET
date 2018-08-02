using RestSharp;

namespace ShikimoriNET.Params.Manga
{
    public class GetByIdParams : IParams
    {
        public int Id { get; set; }

        public virtual IRestRequest GetRequest()
        {
            return new RestRequest("{id}").AddUrlSegment("id", Id.ToString());
        }
    }
}