using System.Collections.Generic;
using System.Threading.Tasks;
using ShikimoriNET.Models.Forum;
using ShikimoriNET.Params.Forum;

namespace ShikimoriNET.Categories.Interfaces
{
    public interface IForumCategory
    {
        Task<IEnumerable<Forum>> ListAsync(ListParams parameters);
    }
}