using RestSharp;

namespace ShikimoriNET.Params.Club
{
    public class GetMangasParams : IParams
    {
        public int Id { get; set; }

        public virtual IRestRequest GetRequest()
        {
            return new RestRequest("{id}/mangas").AddUrlSegment("id", Id.ToString());
        }
    }
}