using System.Threading.Tasks;
using ShikimoriNET.Models.Video;
using ShikimoriNET.Params.Video;

namespace ShikimoriNET.Categories.Interfaces
{
    public interface IVideoCategory
    {
        Task<Video> CreateAsync(CreateParams parameters);
        Task DeleteAsync(DeleteParams parameters);
    }
}