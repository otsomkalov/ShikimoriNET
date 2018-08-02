using System.Collections.Generic;
using System.Threading.Tasks;
using ShikimoriNET.Models.Topic;
using ShikimoriNET.Params.Topic;

namespace ShikimoriNET.Categories.Interfaces
{
    public interface ITopicCategory
    {
        Task<IEnumerable<Topic>> ListAsync(ListParams parameters);
        Task<Topic> GetByIdAsync(GetByIdParams parameters);
    }
}