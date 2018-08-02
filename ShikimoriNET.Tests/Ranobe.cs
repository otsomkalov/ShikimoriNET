using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShikimoriNET.Params.Ranobe;

namespace ShikimoriNET.Tests
{
    [TestClass]
    public class Ranobe
    {
        private readonly ShikimoriApi _api;

        public Ranobe()
        {
            _api = new ShikimoriApi();
        }

        [TestMethod]
        public async Task SearchReturnsValue()
        {
            var animes = await _api.Ranobe.SearchAsync(new SearchParams
            {
                Search = "Пустая"
            });

            Assert.IsNotNull(animes);
        }

        [TestMethod]
        public async Task GetByIdReturnsValue()
        {
            var fullAnime = await _api.Ranobe.GetByIdAsync(new GetByIdParams
            {
                Id = 55215
            });

            Assert.IsNotNull(fullAnime);
        }

        [TestMethod]
        public async Task GetRolesReturnsValue()
        {
            var roles = await _api.Ranobe.GetRolesAsync(new GetRolesParams
            {
                Id = 55215
            });

            Assert.IsNotNull(roles);
        }

        [TestMethod]
        public async Task GetSimilarReturnsValue()
        {
            var similar = await _api.Ranobe.GetSimilarAsync(new GetSimilarParams
            {
                Id = 55215
            });

            Assert.IsNotNull(similar);
        }

        [TestMethod]
        public async Task GetRelatedReturnsValue()
        {
            var relates = await _api.Ranobe.GetRelatedAsync(new GetRelatedParams
            {
                Id = 55215
            });

            Assert.IsNotNull(relates);
        }

        [TestMethod]
        public async Task GetFranchiseReturnsValue()
        {
            var franchise = await _api.Ranobe.GetFranchiseAsync(new GetFranchiseParams
            {
                Id = 55215
            });

            Assert.IsNotNull(franchise);
        }

        [TestMethod]
        public async Task GetExternalLinksReturnsValue()
        {
            var franchise = await _api.Ranobe.GetExternalLinksAsync(new GetExternalLinksParams
            {
                Id = 55215
            });

            Assert.IsNotNull(franchise);
        }
    }
}