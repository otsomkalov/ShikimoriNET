using System.Collections.Generic;
using System.Threading.Tasks;
using ShikimoriNET.Models.Character;
using ShikimoriNET.Params.Anime;

namespace ShikimoriNET.Categories.Interfaces
{
    public interface ICharacterCategory
    {
        Task<IEnumerable<Character>> SearchAsync(SearchParams parameters);
        Task<FullCharacter> GetByIdAsync(GetByIdParams parameters);
    }
}