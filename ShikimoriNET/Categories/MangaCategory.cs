using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using ShikimoriNET.Categories.Interfaces;
using ShikimoriNET.Models;
using ShikimoriNET.Models.Manga;
using ShikimoriNET.Models.Shared;
using ShikimoriNET.Params.Manga;

namespace ShikimoriNET.Categories
{
    public class MangaCategory : BaseCategory, IMangaCategory
    {
        public MangaCategory()
        {
            Client = new RestClient(Url);
        }

        private static string Url => "https://shikimori.org/api/mangas";

        public Task<IEnumerable<Manga>> SearchAsync(SearchParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Manga>>(parameters);
        }

        public Task<FullManga> GetByIdAsync(GetByIdParams parameters)
        {
            return MakeRequestAsync<FullManga>(parameters);
        }

        public Task<IEnumerable<Role>> GetRolesAsync(GetRolesParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Role>>(parameters);
        }

        public Task<IEnumerable<Manga>> GetSimilarAsync(GetSimilarParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Manga>>(parameters);
        }

        public Task<IEnumerable<Related>> GetRelatedAsync(GetRelatedParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Related>>(parameters);
        }

        public Task<Franchise> GetFranchiseAsync(GetFranchiseParams parameters)
        {
            return MakeRequestAsync<Franchise>(parameters);
        }

        public Task<IEnumerable<ExternalLink>> GetExternalLinksAsync(GetExternalLinksParams parameters)
        {
            return MakeRequestAsync<IEnumerable<ExternalLink>>(parameters);
        }
    }
}