using System.Threading.Tasks;
using ShikimoriNET.Params.Friend;

namespace ShikimoriNET.Categories.Interfaces
{
    public interface IFriendCategory
    {
        Task Create(CreateParams parameters);
        Task Delete(DeleteParams parameters);
    }
}