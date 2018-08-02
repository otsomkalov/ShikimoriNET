using RestSharp;

namespace ShikimoriNET.Params.Stats
{
    public class GetActiveUsersParams : IParams
    {
        public IRestRequest GetRequest()
        {
            return new RestRequest("/active_users");
        }
    }
}