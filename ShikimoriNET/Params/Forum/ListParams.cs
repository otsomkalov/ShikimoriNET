using RestSharp;

namespace ShikimoriNET.Params.Forum
{
    public class ListParams : IParams
    {
        public IRestRequest GetRequest()
        {
            return new RestRequest();
        }
    }
}