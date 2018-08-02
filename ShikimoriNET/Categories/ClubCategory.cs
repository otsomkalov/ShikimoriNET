using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using ShikimoriNET.Categories.Interfaces;
using ShikimoriNET.Models.Anime;
using ShikimoriNET.Models.Character;
using ShikimoriNET.Models.Club;
using ShikimoriNET.Models.Manga;
using ShikimoriNET.Models.User;
using ShikimoriNET.Params.Club;

namespace ShikimoriNET.Categories
{
    internal class ClubCategory : BaseCategory, IClubCategory
    {
        public ClubCategory()
        {
            Client = new RestClient(Url);
        }

        private static string Url => "https://shikimori.org/api/clubs";

        public Task<IEnumerable<Club>> ListAsync(ListParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Club>>(parameters);
        }

        public Task<FullClub> GetByIdAsync(GetByIdParams parameters)
        {
            return MakeRequestAsync<FullClub>(parameters);
        }

        public Task<IEnumerable<Anime>> GetAnimesAsync(GetAnimesParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Anime>>(parameters);
        }

        public Task<IEnumerable<Manga>> GetMangasAsync(GetMangasParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Manga>>(parameters);
        }

        public Task<IEnumerable<Manga>> GetRanobesAsync(GetRanobesParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Manga>>(parameters);
        }

        public Task<IEnumerable<Character>> GetCharactersAsync(GetCharactersParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Character>>(parameters);
        }

        public Task<IEnumerable<User>> GetMembersAsync(GetMembersParams parameters)
        {
            return MakeRequestAsync<IEnumerable<User>>(parameters);
        }

        public Task<IEnumerable<Image>> GetImagesAsync(GetImagesParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Image>>(parameters);
        }

        public Task UpdateAsync(UpdateParams parameters)
        {
            return MakeRequestAsync(parameters);
        }

        public Task JoinAsync(JoinParams parameters)
        {
            return MakeRequestAsync(parameters);
        }

        public Task LeaveAsync(LeaveParams parameters)
        {
            return MakeRequestAsync(parameters);
        }
    }
}