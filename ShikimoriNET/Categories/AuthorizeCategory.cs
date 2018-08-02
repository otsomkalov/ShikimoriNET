using System.Threading.Tasks;
using RestSharp;
using ShikimoriNET.Categories.Interfaces;
using ShikimoriNET.Params;
using ShikimoriNET.Params.Authorization;

namespace ShikimoriNET.Categories
{
    internal class AuthorizeCategory : BaseCategory, IAuthorizeCategory
    {
        public AuthorizeCategory()
        {
            Client = new RestClient(Url);
        }

        private static string Url => "https://shikimori.org/oauth/token";

        public Task AuthorizeAsync(AuthorizationParams parameters)
        {
            return MakeRequestAsync(parameters);
        }
    }
}