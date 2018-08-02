using System.Collections.Generic;
using System.Threading.Tasks;
using ShikimoriNET.Models;
using ShikimoriNET.Models.Anime;
using ShikimoriNET.Models.Shared;
using ShikimoriNET.Models.Video;
using ShikimoriNET.Params.Anime;
using ShikimoriNET.Params.AnimeVideo;

namespace ShikimoriNET.Categories.Interfaces
{
    public interface IAnimeCategory
    {
        Task<IEnumerable<Anime>> SearchAsync(SearchParams parameters);
        Task<FullAnime> GetByIdAsync(GetByIdParams parameters);
        Task<IEnumerable<Role>> GetRolesAsync(GetRolesParams parameters);
        Task<IEnumerable<Anime>> GetSimilarAsync(GetSimilarParams parameters);
        Task<IEnumerable<Related>> GetRelatedAsync(GetRelatedParams parameters);
        Task<IEnumerable<Screenshot>> GetScreenshotsAsync(GetScreenshotsParams parameters);
        Task<Franchise> GetFranchiseAsync(GetFranchiseParams parameters);
        Task<IEnumerable<ExternalLink>> GetExternalLinksAsync(GetExternalLinksParams parameters);
        Task<IEnumerable<Video>> GetVideosAsync(GetVideosParams parameters);
        Task CreateAnimeVideoAsync(CreateAnimeVideoParams parameters);
    }
}