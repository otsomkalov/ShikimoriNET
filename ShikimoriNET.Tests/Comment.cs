using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShikimoriNET.Params.Comment;

namespace ShikimoriNET.Tests
{
    [TestClass]
    public class Comment
    {
        private readonly ShikimoriApi _api;

        public Comment()
        {
            _api = new ShikimoriApi();
        }

        [TestMethod]
        public async Task GetByIdReturnsValue()
        {
            var comment = await _api.Comment.GetByIdAsync(new GetByIdParams
            {
                Id = 10000
            });

            Assert.IsNotNull(comment);
        }

        [TestMethod]
        public async Task ListAsyncReturnsValue()
        {
            var comments = await _api.Comment.ListAsync(new ListParams());

            Assert.IsNotNull(comments);
        }
    }
}