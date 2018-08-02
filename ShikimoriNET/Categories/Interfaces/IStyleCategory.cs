using System.Threading.Tasks;
using ShikimoriNET.Models.Style;
using ShikimoriNET.Params.Style;

namespace ShikimoriNET.Categories.Interfaces
{
    public interface IStyleCategory
    {
        Task<Style> GetByIdAsync(GetByIdParams parameters);
        Task<Style> PreviewAsync(PreviewParams parameters);
        Task<Style> CreateAsync(CreateParams parameters);
        Task<Style> UpdateAsync(UpdateParams parameters);
    }
}