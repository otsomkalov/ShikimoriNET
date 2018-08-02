using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShikimoriNET.Params.Publisher;

namespace ShikimoriNET.Tests
{
    [TestClass]
    public class Publisher
    {
        private readonly ShikimoriApi _api;

        public Publisher()
        {
            _api = new ShikimoriApi();
        }

        [TestMethod]
        public async Task ListAsyncReturnsValue()
        {
            var publishers = await _api.Publisher.ListAsync(new ListParams());

            Assert.IsNotNull(publishers);
        }
    }
}