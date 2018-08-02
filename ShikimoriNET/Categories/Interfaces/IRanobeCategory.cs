using System.Collections.Generic;
using System.Threading.Tasks;
using ShikimoriNET.Models;
using ShikimoriNET.Models.Ranobe;
using ShikimoriNET.Models.Shared;
using ShikimoriNET.Params.Ranobe;

namespace ShikimoriNET.Categories.Interfaces
{
    public interface IRanobeCategory
    {
        Task<IEnumerable<Ranobe>> SearchAsync(SearchParams parameters);
        Task<Ranobe> GetByIdAsync(GetByIdParams parameters);
        Task<IEnumerable<Role>> GetRolesAsync(GetRolesParams parameters);
        Task<IEnumerable<Ranobe>> GetSimilarAsync(GetSimilarParams parameters);
        Task<IEnumerable<Related>> GetRelatedAsync(GetRelatedParams parameters);
        Task<Franchise> GetFranchiseAsync(GetFranchiseParams parameters);
        Task<IEnumerable<ExternalLink>> GetExternalLinksAsync(GetExternalLinksParams parameters);
    }
}