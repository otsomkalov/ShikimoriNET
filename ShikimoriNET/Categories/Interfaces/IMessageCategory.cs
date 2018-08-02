using System.Threading.Tasks;
using ShikimoriNET.Models.Message;
using ShikimoriNET.Params.Message;

namespace ShikimoriNET.Categories.Interfaces
{
    public interface IMessageCategory
    {
        Task<Message> GetByIdAsync(GetByIdParams parameters);
        Task CreateAsync(CreateParams parameters);
        Task UpdateAsync(UpdateParams parameters);
        Task DeleteAsync(DeleteParams parameters);
        Task MarkAsReadAsync(MarkAsReadParams parameters);
        Task MarkAllAsReadAsync(MarkAllAsReadParams parameters);
        Task DeleteAllAsync(DeleteAllParams parameters);
    }
}