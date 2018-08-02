using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using ShikimoriNET.Categories.Interfaces;
using ShikimoriNET.Params.Stats;

namespace ShikimoriNET.Categories
{
    internal class StatCategory : BaseCategory, IStatCategory
    {
        public StatCategory()
        {
            Client = new RestClient(Url);
        }

        private static string Url => "https://shikimori.org/api/stats";

        public Task<IEnumerable<int>> GetActiveUsersAsync(GetActiveUsersParams parameters)
        {
            return MakeRequestAsync<IEnumerable<int>>(parameters);
        }
    }
}