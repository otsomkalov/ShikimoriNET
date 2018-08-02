using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShikimoriNET.Params.Stats;

namespace ShikimoriNET.Tests
{
    [TestClass]
    public class Stat
    {
        private readonly ShikimoriApi _api;

        public Stat()
        {
            _api = new ShikimoriApi();
        }

        [TestMethod]
        public async Task GetActiveUsersAsyncReturnsValue()
        {
            var users = await _api.Stat.GetActiveUsersAsync(new GetActiveUsersParams());

            Assert.IsNotNull(users);
        }
    }
}