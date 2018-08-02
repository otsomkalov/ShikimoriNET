using System.Collections.Generic;
using System.Threading.Tasks;
using ShikimoriNET.Models.Device;
using ShikimoriNET.Params.Device;

namespace ShikimoriNET.Categories.Interfaces
{
    public interface IDeviceCategory
    {
        Task<IEnumerable<Device>> ListAsync(ListParams parameters);
        Task CreateAsync(CreateParams parameters);
        Task UpdateAsync(UpdateParams parameters);
        Task DeleteAsync(DeleteParams parameters);
    }
}