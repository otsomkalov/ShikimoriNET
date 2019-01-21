using RestSharp;
using ShikimoriNET.DTO;

namespace ShikimoriNET.Params.Message
{
    public class CreateParams : IParams
    {
        public bool Frontend { get; set; }
        public MessageDTO Message { get; set; }

        public IRestRequest GetRequest()
        {
            return new RestRequest(Method.POST).AddJsonBody(this);
        }
    }
}