using RestSharp;

namespace ShikimoriNET.Params.Device
{
    public class ListParams : IParams
    {
        public virtual IRestRequest GetRequest()
        {
            return new RestRequest();
        }
    }
}