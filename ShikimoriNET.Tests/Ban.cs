using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShikimoriNET.Tests
{
    [TestClass]
    public class Ban
    {
        private readonly ShikimoriApi _api;

        public Ban()
        {
            _api = new ShikimoriApi();
        }

        [TestMethod]
        public async Task ListAsyncReturnsValue()
        {
            var bans = await _api.Bans.ListAsync();

            Assert.IsNotNull(bans);
        }
    }
}