using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShikimoriNET.Tests
{
    [TestClass]
    public class Calendar
    {
        private readonly ShikimoriApi _api;

        public Calendar()
        {
            _api = new ShikimoriApi();
        }

        [TestMethod]
        public async Task GetEventsAsyncReturnsValue()
        {
            var events = await _api.Calendar.GetEventsAsync();

            Assert.IsNotNull(events);
        }
    }
}