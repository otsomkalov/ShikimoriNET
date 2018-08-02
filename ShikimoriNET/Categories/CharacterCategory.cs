using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using ShikimoriNET.Categories.Interfaces;
using ShikimoriNET.Models.Character;
using ShikimoriNET.Params.Anime;

namespace ShikimoriNET.Categories
{
    public class CharacterCategory : BaseCategory, ICharacterCategory
    {
        public CharacterCategory()
        {
            Client = new RestClient(Url);
        }

        private static string Url => "https://shikimori.org/api/characters";

        public Task<IEnumerable<Character>> SearchAsync(SearchParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Character>>(parameters);
        }

        public Task<FullCharacter> GetByIdAsync(GetByIdParams parameters)
        {
            return MakeRequestAsync<FullCharacter>(parameters);
        }
    }
}