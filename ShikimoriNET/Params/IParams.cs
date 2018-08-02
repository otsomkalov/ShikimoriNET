using RestSharp;

namespace ShikimoriNET.Params
{
    public interface IParams
    {
        IRestRequest GetRequest();
    }
}