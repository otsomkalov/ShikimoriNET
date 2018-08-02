using System.Collections.Generic;
using System.Threading.Tasks;
using ShikimoriNET.Models.Anime;
using ShikimoriNET.Models.Character;
using ShikimoriNET.Models.Club;
using ShikimoriNET.Models.Manga;
using ShikimoriNET.Models.User;
using ShikimoriNET.Params.Club;

namespace ShikimoriNET.Categories.Interfaces
{
    public interface IClubCategory
    {
        Task<IEnumerable<Club>> ListAsync(ListParams parameters);
        Task<FullClub> GetByIdAsync(GetByIdParams parameters);
        Task<IEnumerable<Anime>> GetAnimesAsync(GetAnimesParams parameters);
        Task<IEnumerable<Manga>> GetMangasAsync(GetMangasParams parameters);
        Task<IEnumerable<Manga>> GetRanobesAsync(GetRanobesParams parameters);
        Task<IEnumerable<Character>> GetCharactersAsync(GetCharactersParams parameters);
        Task<IEnumerable<User>> GetMembersAsync(GetMembersParams parameters);
        Task<IEnumerable<Image>> GetImagesAsync(GetImagesParams parameters);
        Task UpdateAsync(UpdateParams parameters);
        Task JoinAsync(JoinParams parameters);
        Task LeaveAsync(LeaveParams parameters);
    }
}