using System.Collections.Generic;
using System.Threading.Tasks;
using ShikimoriNET.Models.Comment;
using ShikimoriNET.Params.Comment;

namespace ShikimoriNET.Categories.Interfaces
{
    public interface ICommentCategory
    {
        Task<Comment> GetByIdAsync(GetByIdParams parameters);
        Task<IEnumerable<Comment>> ListAsync(ListParams parameters);
        Task CreateCommentAsync(CreateParams parameters);
        Task UpdateCommentAsync(UpdateParams parameters);
        Task DeleteCommentAsync(DeleteParams parameters);
    }
}