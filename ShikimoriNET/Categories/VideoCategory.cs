using System.Threading.Tasks;
using RestSharp;
using ShikimoriNET.Categories.Interfaces;
using ShikimoriNET.Models.Video;
using ShikimoriNET.Params.Video;

namespace ShikimoriNET.Categories
{
    internal class VideoCategory : BaseCategory, IVideoCategory
    {
        public VideoCategory()
        {
            Client = new RestClient(Url);
        }

        private static string Url => "https://shikimori.org/api/user_rates";

        public Task<Video> CreateAsync(CreateParams parameters)
        {
            return MakeRequestAsync<Video>(parameters);
        }

        public Task DeleteAsync(DeleteParams parameters)
        {
            return MakeRequestAsync(parameters);
        }
    }
}