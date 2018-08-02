using RestSharp;
using ShikimoriNET.Params;

namespace ShikimoriNET.Models.Club
{
    public class JoinParams : IParams
    {
        public int Id { get; set; }

        public virtual IRestRequest GetRequest()
        {
            return new RestRequest("{id}/join", Method.POST).AddUrlSegment("id", Id.ToString());
        }
    }
}