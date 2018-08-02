using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using ShikimoriNET.Categories.Interfaces;
using ShikimoriNET.Models.Forum;
using ShikimoriNET.Params.Forum;

namespace ShikimoriNET.Categories
{
    internal class ForumCategory : BaseCategory, IForumCategory
    {
        public ForumCategory()
        {
            Client = new RestClient(Url);
        }

        private static string Url => "https://shikimori.org/api/forums";

        public Task<IEnumerable<Forum>> ListAsync(ListParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Forum>>(parameters);
        }
    }
}