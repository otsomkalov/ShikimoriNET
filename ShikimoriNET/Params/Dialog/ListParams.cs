using RestSharp;

namespace ShikimoriNET.Params.Dialog
{
    public class ListParams : IParams
    {
        public virtual IRestRequest GetRequest()
        {
            return new RestRequest();
        }
    }
}