using RestSharp;

namespace ShikimoriNET.Params.Club
{
    public class GetCharactersParams : IParams
    {
        public int Id { get; set; }

        public virtual IRestRequest GetRequest()
        {
            return new RestRequest("{id}/characters").AddUrlSegment("id", Id.ToString());
        }
    }
}