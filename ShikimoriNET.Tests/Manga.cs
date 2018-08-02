using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShikimoriNET.Params.Manga;

namespace ShikimoriNET.Tests
{
    [TestClass]
    public class Manga
    {
        private readonly ShikimoriApi _api;

        public Manga()
        {
            _api = new ShikimoriApi();
        }

        [TestMethod]
        public async Task SearchReturnsValue()
        {
            var animes = await _api.Manga.SearchAsync(new SearchParams
            {
                Search = "Ковбой"
            });

            Assert.IsNotNull(animes);
        }

        [TestMethod]
        public async Task GetByIdReturnsValue()
        {
            var fullAnime = await _api.Manga.GetByIdAsync(new GetByIdParams
            {
                Id = 1
            });

            Assert.IsNotNull(fullAnime);
        }

        [TestMethod]
        public async Task GetRolesReturnsValue()
        {
            var roles = await _api.Manga.GetRolesAsync(new GetRolesParams
            {
                Id = 1
            });

            Assert.IsNotNull(roles);
        }

        [TestMethod]
        public async Task GetSimilarReturnsValue()
        {
            var similar = await _api.Manga.GetSimilarAsync(new GetSimilarParams
            {
                Id = 1
            });

            Assert.IsNotNull(similar);
        }

        [TestMethod]
        public async Task GetRelatedReturnsValue()
        {
            var relates = await _api.Manga.GetRelatedAsync(new GetRelatedParams
            {
                Id = 1
            });

            Assert.IsNotNull(relates);
        }

        [TestMethod]
        public async Task GetFranchiseReturnsValue()
        {
            var franchise = await _api.Manga.GetFranchiseAsync(new GetFranchiseParams
            {
                Id = 1
            });

            Assert.IsNotNull(franchise);
        }

        [TestMethod]
        public async Task GetExternalLinksReturnsValue()
        {
            var franchise = await _api.Manga.GetExternalLinksAsync(new GetExternalLinksParams
            {
                Id = 1
            });

            Assert.IsNotNull(franchise);
        }
    }
}