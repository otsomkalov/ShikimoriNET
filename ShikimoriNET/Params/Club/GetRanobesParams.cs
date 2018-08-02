using RestSharp;

namespace ShikimoriNET.Params.Club
{
    public class GetRanobesParams : IParams
    {
        public int Id { get; set; }

        public virtual IRestRequest GetRequest()
        {
            return new RestRequest("{id}/ranobe").AddUrlSegment("id", Id.ToString());
        }
    }
}