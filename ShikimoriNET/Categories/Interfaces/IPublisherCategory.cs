using System.Collections.Generic;
using System.Threading.Tasks;
using ShikimoriNET.Models.Publisher;
using ShikimoriNET.Params.Publisher;

namespace ShikimoriNET.Categories.Interfaces
{
    public interface IPublisherCategory
    {
        Task<IEnumerable<Publisher>> ListAsync(ListParams parameters);
    }
}