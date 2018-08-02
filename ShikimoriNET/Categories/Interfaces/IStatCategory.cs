using System.Collections.Generic;
using System.Threading.Tasks;
using ShikimoriNET.Params.Stats;

namespace ShikimoriNET.Categories.Interfaces
{
    public interface IStatCategory
    {
        Task<IEnumerable<int>> GetActiveUsersAsync(GetActiveUsersParams parameters);
    }
}