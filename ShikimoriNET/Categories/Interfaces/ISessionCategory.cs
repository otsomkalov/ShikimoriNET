using System.Threading.Tasks;
using ShikimoriNET.Params.Session;

namespace ShikimoriNET.Categories.Interfaces
{
    public interface ISessionCategory
    {
        Task Create(CreateParams parameters);
    }
}