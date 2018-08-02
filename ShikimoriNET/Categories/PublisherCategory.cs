using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using ShikimoriNET.Categories.Interfaces;
using ShikimoriNET.Models.Publisher;
using ShikimoriNET.Params.Publisher;

namespace ShikimoriNET.Categories
{
    internal class PublisherCategory : BaseCategory, IPublisherCategory
    {
        public PublisherCategory()
        {
            Client = new RestClient(Url);
        }

        private static string Url => "https://shikimori.org/api/publishers";

        public Task<IEnumerable<Publisher>> ListAsync(ListParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Publisher>>(parameters);
        }
    }
}