using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShikimoriNET.Params.Topic;

namespace ShikimoriNET.Tests
{
    [TestClass]
    public class Topic
    {
        private readonly ShikimoriApi _api;

        public Topic()
        {
            _api = new ShikimoriApi();
        }

        [TestMethod]
        public async Task ListAsyncReturnsValue()
        {
            var topics = await _api.Topic.ListAsync(new ListParams
            {
                Forum = Enums.Topic.Forum.All
            });

            Assert.IsNotNull(topics);
        }
    }
}