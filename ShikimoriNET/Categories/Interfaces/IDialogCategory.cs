using System.Collections.Generic;
using System.Threading.Tasks;
using ShikimoriNET.Models.Dialog;
using ShikimoriNET.Params.Dialog;

namespace ShikimoriNET.Categories.Interfaces
{
    public interface IDialogCategory
    {
        Task<IEnumerable<Dialog>> ListAsync(ListParams parameters);
        Task<Dialog> GetById(GetByIdParams parameters);
        Task DeleteAsync(DeleteParams parameters);
    }
}