using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShikimoriNET.Params.Dialog;

namespace ShikimoriNET.Tests
{
    [TestClass]
    public class Dialog
    {
        private readonly ShikimoriApi _api;

        public Dialog()
        {
            _api = new ShikimoriApi();
        }

        [TestMethod]
        public async Task ListAsyncReturnsValue()
        {
            var dialogs = await _api.Dialog.ListAsync(new ListParams());

            Assert.IsNotNull(dialogs);
        }
    }
}