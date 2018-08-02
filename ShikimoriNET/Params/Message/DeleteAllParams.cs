using RestSharp;
using ShikimoriNET.Enums;

namespace ShikimoriNET.Params.Message
{
    public class DeleteAllParams : IParams
    {
        public bool? Frontend { get; set; }
        public MessageType? Type { get; set; }

        public IRestRequest GetRequest()
        {
            return new RestRequest("delete_all", Method.POST).AddBody(this);
        }
    }
}