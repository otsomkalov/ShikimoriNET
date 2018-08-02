using System.Collections.Generic;
using RestSharp;

namespace ShikimoriNET.Params.Appear
{
    public class MarkAsReadParams : IParams
    {
        public IEnumerable<string> Ids { get; set; }

        public virtual IRestRequest GetRequest()
        {
            return new RestRequest("appear", Method.POST).AddBody(string.Join(",", Ids));
        }
    }
}