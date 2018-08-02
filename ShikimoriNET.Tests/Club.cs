using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShikimoriNET.Params.Club;

namespace ShikimoriNET.Tests
{
    [TestClass]
    public class Club
    {
        private readonly ShikimoriApi _api;

        public Club()
        {
            _api = new ShikimoriApi();
        }

        [TestMethod]
        public async Task ListAsyncReturnsValue()
        {
            var clubs = await _api.Club.ListAsync(new ListParams
            {
                Search = "Naruto",
                Limit = 10,
                Page = 1
            });

            Assert.IsNotNull(clubs);
        }

        [TestMethod]
        public async Task GetByIdAsyncReturnsValue()
        {
            var club = await _api.Club.GetByIdAsync(new GetByIdParams
            {
                Id = 707
            });

            Assert.IsNotNull(club);
        }

        [TestMethod]
        public async Task GetAnimesAsyncReturnsValue()
        {
            var animes = await _api.Club.GetAnimesAsync(new GetAnimesParams
            {
                Id = 707
            });

            Assert.IsNotNull(animes);
        }

        [TestMethod]
        public async Task GetMangasAsyncReturnsValue()
        {
            var mangas = await _api.Club.GetMangasAsync(new GetMangasParams
            {
                Id = 707
            });

            Assert.IsNotNull(mangas);
        }

        [TestMethod]
        public async Task GetRanobesAsyncReturnsValue()
        {
            var ranobes = await _api.Club.GetRanobesAsync(new GetRanobesParams
            {
                Id = 707
            });

            Assert.IsNotNull(ranobes);
        }

        [TestMethod]
        public async Task GetCharactersAsyncReturnsValue()
        {
            var characters = await _api.Club.GetCharactersAsync(new GetCharactersParams
            {
                Id = 707
            });

            Assert.IsNotNull(characters);
        }

        [TestMethod]
        public async Task GetMembersAsyncReturnsValue()
        {
            var members = await _api.Club.GetMembersAsync(new GetMembersParams
            {
                Id = 707
            });

            Assert.IsNotNull(members);
        }

        [TestMethod]
        public async Task GetImagesAsyncReturnsValue()
        {
            var images = await _api.Club.GetImagesAsync(new GetImagesParams
            {
                Id = 707
            });

            Assert.IsNotNull(images);
        }
    }
}