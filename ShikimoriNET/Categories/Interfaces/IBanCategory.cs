using System.Collections.Generic;
using System.Threading.Tasks;
using ShikimoriNET.Models.Ban;

namespace ShikimoriNET.Categories.Interfaces
{
    public interface IBanCategory
    {
        Task<IEnumerable<Ban>> ListAsync();
    }
}