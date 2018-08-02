using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using ShikimoriNET.Categories.Interfaces;
using ShikimoriNET.Models.Studio;
using ShikimoriNET.Params.Studio;

namespace ShikimoriNET.Categories
{
    internal class StudioCategory : BaseCategory, IStudioCategory
    {
        public StudioCategory()
        {
            Client = new RestClient(Url);
        }

        private static string Url => "https://shikimori.org/api/studios";

        public Task<IEnumerable<Studio>> ListAsync(ListParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Studio>>(parameters);
        }
    }
}