using RestSharp;

namespace ShikimoriNET.Params.People
{
    public class SearchParams : IParams
    {
        public IRestRequest GetRequest()
        {
            return new RestRequest("/search");
        }
    }
}