using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShikimoriNET.Params.Studio;

namespace ShikimoriNET.Tests
{
    [TestClass]
    public class Studio
    {
        private readonly ShikimoriApi _api;

        public Studio()
        {
            _api = new ShikimoriApi();
        }

        [TestMethod]
        public async Task ListAsyncReturnsValue()
        {
            var studios = await _api.Studio.ListAsync(new ListParams());

            Assert.IsNotNull(studios);
        }
    }
}