using RestSharp;
using ShikimoriNET.DTO;

namespace ShikimoriNET.Params.Device
{
    public class CreateParams : IParams
    {
        public DeviceDTO Device { get; set; }

        public virtual IRestRequest GetRequest()
        {
            return new RestRequest(Method.POST).AddJsonBody(Device);
        }
    }
}