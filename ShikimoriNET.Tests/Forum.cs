using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShikimoriNET.Params.Forum;

namespace ShikimoriNET.Tests
{
    [TestClass]
    public class Forum
    {
        private readonly ShikimoriApi _api;

        public Forum()
        {
            _api = new ShikimoriApi();
        }

        [TestMethod]
        public async Task ListAsyncReturnsValue()
        {
            var forums = await _api.Forum.ListAsync(new ListParams());

            Assert.IsNotNull(forums);
        }
    }
}