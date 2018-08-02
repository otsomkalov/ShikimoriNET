using System.Collections.Generic;
using System.Threading.Tasks;
using ShikimoriNET.Models.Studio;
using ShikimoriNET.Params.Studio;

namespace ShikimoriNET.Categories.Interfaces
{
    public interface IStudioCategory
    {
        Task<IEnumerable<Studio>> ListAsync(ListParams parameters);
    }
}