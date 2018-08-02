using RestSharp;

namespace ShikimoriNET.Params.Club
{
    public class GetMembersParams : IParams
    {
        public int Id { get; set; }

        public virtual IRestRequest GetRequest()
        {
            return new RestRequest("{id}/members").AddUrlSegment("id", Id.ToString());
        }
    }
}