using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using ShikimoriNET.Categories.Interfaces;
using ShikimoriNET.Models;
using ShikimoriNET.Models.Anime;
using ShikimoriNET.Models.Shared;
using ShikimoriNET.Models.Video;
using ShikimoriNET.Params.Anime;
using ShikimoriNET.Params.AnimeVideo;

namespace ShikimoriNET.Categories
{
    public class AnimeCategory : BaseCategory, IAnimeCategory
    {
        public AnimeCategory()
        {
            Client = new RestClient(Url);
        }

        private static string Url => "https://shikimori.org/api/animes";

        public Task<IEnumerable<Anime>> SearchAsync(SearchParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Anime>>(parameters);
        }

        public Task<FullAnime> GetByIdAsync(GetByIdParams parameters)
        {
            return MakeRequestAsync<FullAnime>(parameters);
        }

        public Task<IEnumerable<Role>> GetRolesAsync(GetRolesParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Role>>(parameters);
        }

        public Task<IEnumerable<Anime>> GetSimilarAsync(GetSimilarParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Anime>>(parameters);
        }

        public Task<IEnumerable<Related>> GetRelatedAsync(GetRelatedParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Related>>(parameters);
        }

        public Task<IEnumerable<Screenshot>> GetScreenshotsAsync(GetScreenshotsParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Screenshot>>(parameters);
        }

        public Task<Franchise> GetFranchiseAsync(GetFranchiseParams parameters)
        {
            return MakeRequestAsync<Franchise>(parameters);
        }

        public Task<IEnumerable<ExternalLink>> GetExternalLinksAsync(GetExternalLinksParams parameters)
        {
            return MakeRequestAsync<IEnumerable<ExternalLink>>(parameters);
        }

        public Task<IEnumerable<Video>> GetVideosAsync(GetVideosParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Video>>(parameters);
        }

        public Task CreateAnimeVideoAsync(CreateAnimeVideoParams parameters)
        {
            return MakeRequestAsync(parameters);
        }
    }
}