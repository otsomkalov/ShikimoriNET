using RestSharp;

namespace ShikimoriNET.Params.Studio
{
    public class ListParams : IParams
    {
        public IRestRequest GetRequest()
        {
            return new RestRequest();
        }
    }
}