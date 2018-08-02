using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShikimoriNET.Enums;
using ShikimoriNET.Enums.Anime;
using ShikimoriNET.Params.Anime;

namespace ShikimoriNET.Tests
{
    [TestClass]
    public class Anime
    {
        private readonly ShikimoriApi _api;

        public Anime()
        {
            _api = new ShikimoriApi();
        }

        [TestMethod]
        public async Task SearchAsyncReturnsValue()
        {
            var animes = await _api.Anime.SearchAsync(new SearchParams
            {
                Search = "Naruto",
                Page = 1,
                Limit = 10,
                Order = Order.Id,
                Censored = true,
                Duration = Duration.D,
                Kind = Kind.Tv,
                Status = Status.Released,
                Season = "200x",
                Score = 6,
                Rating = Rating.G
            });

            Assert.IsNotNull(animes);
        }

        [TestMethod]
        public async Task GetByIdAsyncReturnsValue()
        {
            var fullAnime = await _api.Anime.GetByIdAsync(new GetByIdParams
            {
                Id = 1
            });

            Assert.IsNotNull(fullAnime);
        }

        [TestMethod]
        public async Task GetRolesAsyncReturnsValue()
        {
            var roles = await _api.Anime.GetRolesAsync(new GetRolesParams
            {
                Id = 1
            });

            Assert.IsNotNull(roles);
        }

        [TestMethod]
        public async Task GetSimilarAsyncReturnsValue()
        {
            var similar = await _api.Anime.GetSimilarAsync(new GetSimilarParams
            {
                Id = 1
            });

            Assert.IsNotNull(similar);
        }

        [TestMethod]
        public async Task GetRelatedAsyncReturnsValue()
        {
            var relates = await _api.Anime.GetRelatedAsync(new GetRelatedParams
            {
                Id = 1
            });

            Assert.IsNotNull(relates);
        }

        [TestMethod]
        public async Task GetScreenshotsAsyncReturnsValue()
        {
            var screenshots = await _api.Anime.GetScreenshotsAsync(new GetScreenshotsParams
            {
                Id = 1
            });

            Assert.IsNotNull(screenshots);
        }

        [TestMethod]
        public async Task GetFranchiseAsyncReturnsValue()
        {
            var franchise = await _api.Anime.GetFranchiseAsync(new GetFranchiseParams
            {
                Id = 1
            });

            Assert.IsNotNull(franchise);
        }

        [TestMethod]
        public async Task GetExternalLinksAsyncReturnsValue()
        {
            var franchise = await _api.Anime.GetExternalLinksAsync(new GetExternalLinksParams
            {
                Id = 1
            });

            Assert.IsNotNull(franchise);
        }

        [TestMethod]
        public async Task GetVideosAsyncReturnsValue()
        {
            var videos = await _api.Anime.GetVideosAsync(new GetVideosParams
            {
                Id = 1
            });

            Assert.IsNotNull(videos);
        }
    }
}