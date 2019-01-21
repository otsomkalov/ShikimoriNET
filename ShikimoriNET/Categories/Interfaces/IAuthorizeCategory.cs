using System.Threading.Tasks;
using ShikimoriNET.Params.Authorization;

namespace ShikimoriNET.Categories.Interfaces
{
    public interface IAuthorizeCategory
    {
        Task AuthorizeAsync(AuthorizationParams parameters);
    }
}