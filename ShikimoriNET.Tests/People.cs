using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShikimoriNET.Params.People;

namespace ShikimoriNET.Tests
{
    [TestClass]
    public class People
    {
        private readonly ShikimoriApi _api;

        public People()
        {
            _api = new ShikimoriApi();
        }

        [TestMethod]
        public async Task SearchAsyncReturnsValue()
        {
        }

        [TestMethod]
        public async Task GetByIdReturnsValue()
        {
            var person = await _api.People.GetByIdAsync(new GetByIdParams
            {
                Id = 1
            });

            Assert.IsNotNull(person);
        }
    }
}