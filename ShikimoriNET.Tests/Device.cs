using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShikimoriNET.Params.Device;

namespace ShikimoriNET.Tests
{
    [TestClass]
    public class Device
    {
        private readonly ShikimoriApi _api;

        public Device()
        {
            _api = new ShikimoriApi();
        }

        [TestMethod]
        public async Task ListAsyncReturnsValue()
        {
            var devices = await _api.Device.ListAsync(new ListParams());

            Assert.IsNotNull(devices);
        }
    }
}