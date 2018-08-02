using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShikimoriNET.Params.Style;

namespace ShikimoriNET.Tests
{
    [TestClass]
    public class Style
    {
        private readonly ShikimoriApi _api;

        public Style()
        {
            _api = new ShikimoriApi();
        }

        [TestMethod]
        public async Task GetByIdAsyncReturnsValue()
        {
            var style = await _api.Style.GetByIdAsync(new GetByIdParams
            {
                Id = 1
            });

            Assert.IsNotNull(style);
        }
    }
}