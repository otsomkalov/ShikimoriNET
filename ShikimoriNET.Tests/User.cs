using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShikimoriNET.Params.User;

namespace ShikimoriNET.Tests
{
    [TestClass]
    public class User
    {
        private readonly ShikimoriApi _api;

        public User()
        {
            _api = new ShikimoriApi();
        }

        [TestMethod]
        public async Task ListUsersReturnsValue()
        {
            var users = await _api.User.ListUsersAsync(new ListParams());

            Assert.IsNotNull(users);
        }

        [TestMethod]
        public async Task GetByIdReturnsValue()
        {
            var user = await _api.User.GetByIdAsync(new GetByIdParams
            {
                Id = 1
            });

            Assert.IsNotNull(user);
        }

        [TestMethod]
        public async Task GetInfoAsyncReturnsValue()
        {
            var userInfo = await _api.User.GetInfoAsync(new GetInfoParams
            {
                Id = 1
            });

            Assert.IsNotNull(userInfo);
        }

        [TestMethod]
        public async Task GetFriendsAsyncReturnsValue()
        {
            var friends = await _api.User.GetFriendsAsync(new GetFriendsParams
            {
                Id = 1
            });

            Assert.IsNotNull(friends);
        }

        [TestMethod]
        public async Task GetAnimeAsyncReturnsValue()
        {
            var animes = await _api.User.GetAnimesAsync(new GetAnimesParams
            {
                Id = 1
            });

            Assert.IsNotNull(animes);
        }

        [TestMethod]
        public async Task GetMangasAsyncReturnsValue()
        {
            var mangas = await _api.User.GetMangasAsync(new GetMangasParams
            {
                Id = 1
            });

            Assert.IsNotNull(mangas);
        }

        [TestMethod]
        public async Task GetFavouritesAsyncReturnsValue()
        {
            var favourites = await _api.User.GetFavouritesAsync(new GetFavouritesParams
            {
                Id = 1
            });

            Assert.IsNotNull(favourites);
        }

        [TestMethod]
        public async Task GetHistoryAsyncReturnsValue()
        {
            var history = await _api.User.GetHistoryAsync(new GetHistoryParams
            {
                Id = 1
            });

            Assert.IsNotNull(history);
        }

        [TestMethod]
        public async Task GetBansAsyncReturnsValue()
        {
            var bans = await _api.User.GetBansAsync(new GetBansParams
            {
                Id = 1
            });

            Assert.IsNotNull(bans);
        }

        [TestMethod]
        public async Task GetVideoReportsAsyncReturnsValue()
        {
            var clubs = await _api.User.GetVideoReportsAsync(new GetVideoReportsParams
            {
                Page = 1,
                Limit = 1
            });

            Assert.IsNotNull(clubs);
        }
    }
}