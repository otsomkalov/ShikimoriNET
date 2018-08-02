using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShikimoriNET.Params.Achievements;

namespace ShikimoriNET.Tests
{
    [TestClass]
    public class Achievement
    {
        private readonly ShikimoriApi _api;

        public Achievement()
        {
            _api = new ShikimoriApi();
        }

        [TestMethod]
        public async Task GetByUserIdAsyncReturnsValue()
        {
            var achievements = await _api.Achievement.GetByUserIdAsync(new GetAchievementsParams
            {
                UserId = 1
            });

            Assert.IsNotNull(achievements);
        }
    }
}