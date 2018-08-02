using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using ShikimoriNET.Categories.Interfaces;
using ShikimoriNET.Models.Device;
using ShikimoriNET.Params.Device;

namespace ShikimoriNET.Categories
{
    internal class DeviceCategory : BaseCategory, IDeviceCategory
    {
        public DeviceCategory()
        {
            Client = new RestClient(Url);
        }

        private static string Url => "https://shikimori.org/api/devices";

        public Task<IEnumerable<Device>> ListAsync(ListParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Device>>(parameters);
        }

        public Task CreateAsync(CreateParams parameters)
        {
            return MakeRequestAsync(parameters);
        }

        public Task UpdateAsync(UpdateParams parameters)
        {
            return MakeRequestAsync(parameters);
        }

        public Task DeleteAsync(DeleteParams parameters)
        {
            return MakeRequestAsync(parameters);
        }
    }
}