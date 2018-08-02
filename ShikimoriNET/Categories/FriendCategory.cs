using System.Threading.Tasks;
using RestSharp;
using ShikimoriNET.Categories.Interfaces;
using ShikimoriNET.Params.Friend;

namespace ShikimoriNET.Categories
{
    internal class FriendCategory : BaseCategory, IFriendCategory
    {
        public FriendCategory()
        {
            Client = new RestClient(Url);
        }

        private static string Url => "https://shikimori.org/api/friends";

        public Task Create(CreateParams parameters)
        {
            return MakeRequestAsync(parameters);
        }

        public Task Delete(DeleteParams parameters)
        {
            return MakeRequestAsync(parameters);
        }
    }
}