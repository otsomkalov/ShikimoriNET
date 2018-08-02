using RestSharp;
using ShikimoriNET.DTO;

namespace ShikimoriNET.Params.Device
{
    public class UpdateParams : IParams
    {
        public int Id { get; set; }
        public DeviceDTO Device { get; set; }

        public virtual IRestRequest GetRequest()
        {
            return new RestRequest("{id}", Method.PUT).AddUrlSegment("id", Id.ToString()).AddBody(Device);
        }
    }
}