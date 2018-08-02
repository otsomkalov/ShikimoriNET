using RestSharp;

namespace ShikimoriNET.Params.Manga
{
    public class GetRolesParams : IParams
    {
        public int Id { get; set; }

        public virtual IRestRequest GetRequest()
        {
            return new RestRequest("{id}/roles").AddUrlSegment("id", Id.ToString());
        }
    }
}