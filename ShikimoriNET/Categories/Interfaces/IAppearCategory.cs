using System.Threading.Tasks;
using ShikimoriNET.Params.Appear;

namespace ShikimoriNET.Categories.Interfaces
{
    public interface IAppearCategory
    {
        Task MarkAsReadAsync(MarkAsReadParams parameters);
    }
}