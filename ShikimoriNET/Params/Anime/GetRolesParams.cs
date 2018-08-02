using RestSharp;

namespace ShikimoriNET.Params.Anime
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