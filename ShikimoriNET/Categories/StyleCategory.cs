using System.Threading.Tasks;
using RestSharp;
using ShikimoriNET.Categories.Interfaces;
using ShikimoriNET.Models.Style;
using ShikimoriNET.Params.Style;

namespace ShikimoriNET.Categories
{
    internal class StyleCategory : BaseCategory, IStyleCategory
    {
        public StyleCategory()
        {
            Client = new RestClient(Url);
        }

        private static string Url => "https://shikimori.org/api/styles";

        public Task<Style> GetByIdAsync(GetByIdParams parameters)
        {
            return MakeRequestAsync<Style>(parameters);
        }

        public Task<Style> PreviewAsync(PreviewParams parameters)
        {
            return MakeRequestAsync<Style>(parameters);
        }

        public Task<Style> CreateAsync(CreateParams parameters)
        {
            return MakeRequestAsync<Style>(parameters);
        }

        public Task<Style> UpdateAsync(UpdateParams parameters)
        {
            return MakeRequestAsync<Style>(parameters);
        }
    }
}