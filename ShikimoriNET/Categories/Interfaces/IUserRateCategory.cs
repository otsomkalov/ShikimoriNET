using System.Threading.Tasks;
using ShikimoriNET.Params.UserRate;

namespace ShikimoriNET.Categories.Interfaces
{
    public interface IUserRateCategory
    {
        Task CleanHistoryAndRatesAsync(CleanHistoryAndRatesParams parameters);
        Task ResetAllAsync(ResetAllParams parameters);
    }
}