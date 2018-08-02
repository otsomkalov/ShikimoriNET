using System.Collections.Generic;
using RestSharp;

namespace ShikimoriNET.Params.Message
{
    public class MarkAsReadParams : IParams
    {
        public IEnumerable<int> Ids { get; set; }

        public IRestRequest GetRequest()
        {
            return new RestRequest("mark_read", Method.POST).AddBody(Ids);
        }
    }
}