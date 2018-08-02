using RestSharp;
using ShikimoriNET.Params;

namespace ShikimoriNET.Models.Club
{
    public class LeaveParams : IParams
    {
        public int Id { get; set; }

        public virtual IRestRequest GetRequest()
        {
            return new RestRequest("{id}/leave", Method.POST).AddUrlSegment("id", Id.ToString());
        }
    }
}