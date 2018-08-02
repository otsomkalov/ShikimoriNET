using System.Threading.Tasks;
using RestSharp;
using ShikimoriNET.Categories.Interfaces;
using ShikimoriNET.Params.Session;

namespace ShikimoriNET.Categories
{
    internal class SessionCategory : BaseCategory, ISessionCategory
    {
        public SessionCategory()
        {
            Client = new RestClient(Url);
        }

        private static string Url => "https://shikimori.org/api/sessions";

        public Task Create(CreateParams parameters)
        {
            return MakeRequestAsync(parameters);
        }
    }
}