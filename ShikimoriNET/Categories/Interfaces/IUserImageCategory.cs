using System.Threading.Tasks;
using ShikimoriNET.Models.UserImage;
using ShikimoriNET.Params.UserImage;

namespace ShikimoriNET.Categories.Interfaces
{
    public interface IUserImageCategory
    {
        Task<UserImage> CreateAsync(CreateParams parameters);
    }
}