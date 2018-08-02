using RestSharp;
using ShikimoriNET.DTO;

namespace ShikimoriNET.Params.Message
{
    public class UpdateParams : IParams
    {
        public int Id { get; set; }
        public bool? Frontend { get; set; }
        public MessageDTO Message { get; set; }

        public IRestRequest GetRequest()
        {
            return new RestRequest("{id}", Method.PUT).AddUrlSegment("id", Id.ToString()).AddBody(this);
        }
    }
}