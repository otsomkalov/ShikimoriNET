using System.Threading.Tasks;
using RestSharp;
using ShikimoriNET.Categories.Interfaces;
using ShikimoriNET.Params.UserRate;

namespace ShikimoriNET.Categories
{
    internal class UserRateCategory : BaseCategory, IUserRateCategory
    {
        public UserRateCategory()
        {
            Client = new RestClient(Url);
        }

        private static string Url => "https://shikimori.org/api/user_rates";

        public Task CleanHistoryAndRatesAsync(CleanHistoryAndRatesParams parameters)
        {
            return MakeRequestAsync(parameters);
        }

        public Task ResetAllAsync(ResetAllParams parameters)
        {
            return MakeRequestAsync(parameters);
        }
    }
}