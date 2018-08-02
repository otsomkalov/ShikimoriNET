using System.Threading.Tasks;
using RestSharp;
using ShikimoriNET.Categories.Interfaces;
using ShikimoriNET.Models.UserImage;
using ShikimoriNET.Params.UserImage;

namespace ShikimoriNET.Categories
{
    internal class UserImageCategory : BaseCategory, IUserImageCategory
    {
        public UserImageCategory()
        {
            Client = new RestClient(Url);
        }

        private static string Url => "https://shikimori.org/api/user_images";

        public Task<UserImage> CreateAsync(CreateParams parameters)
        {
            return MakeRequestAsync<UserImage>(parameters);
        }
    }
}