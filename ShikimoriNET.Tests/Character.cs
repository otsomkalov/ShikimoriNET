using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShikimoriNET.Params.Anime;

namespace ShikimoriNET.Tests
{
    [TestClass]
    public class Character
    {
        private readonly ShikimoriApi _api;

        public Character()
        {
            _api = new ShikimoriApi();
        }

        [TestMethod]
        public async Task GetByIdAsyncReturnsValue()
        {
            var character = await _api.Character.GetByIdAsync(new GetByIdParams
            {
                Id = 1
            });

            Assert.IsNotNull(character);
        }
    }
}