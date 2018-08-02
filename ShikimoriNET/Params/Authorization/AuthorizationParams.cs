using RestSharp;

namespace ShikimoriNET.Params.Authorization
{
    public class AuthorizationParams : IParams
    {
        public string ApplicationName { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string RedirectUri { get; set; }

        public IRestRequest GetRequest()
        {
            return new RestRequest(Method.POST).AddJsonBody(this);
        }
    }
}