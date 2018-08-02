using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using ShikimoriNET.Categories.Interfaces;
using ShikimoriNET.Models.Ban;

namespace ShikimoriNET.Categories
{
    public class BanCategory : BaseCategory, IBanCategory
    {
        public BanCategory()
        {
            Client = new RestClient(Url);
        }

        private static string Url => "https://shikimori.org/api/bans";

        public Task<IEnumerable<Ban>> ListAsync()
        {
            return MakeRequestAsync<IEnumerable<Ban>>();
        }
    }
}