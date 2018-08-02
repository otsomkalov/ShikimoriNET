using RestSharp;
using ShikimoriNET.Enums;

namespace ShikimoriNET.Params.Message
{
    public class MarkAllAsReadParams : IParams
    {
        public bool? Frontend { get; set; }
        public MessageType? Type { get; set; }

        public IRestRequest GetRequest()
        {
            return new RestRequest("read_all", Method.POST).AddBody(this);
        }
    }
}