using RestSharp;

namespace ShikimoriNET.Params.Publisher
{
    public class ListParams : IParams
    {
        public IRestRequest GetRequest()
        {
            return new RestRequest();
        }
    }
}