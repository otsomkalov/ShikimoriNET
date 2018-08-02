using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using ShikimoriNET.Categories.Interfaces;
using ShikimoriNET.Models;
using ShikimoriNET.Models.Anime;
using ShikimoriNET.Models.Ban;
using ShikimoriNET.Models.Club;
using ShikimoriNET.Models.Manga;
using ShikimoriNET.Models.Message;
using ShikimoriNET.Models.User;
using ShikimoriNET.Params.User;

namespace ShikimoriNET.Categories
{
    public class UserCategory : BaseCategory, IUserCategory
    {
        public UserCategory()
        {
            Client = new RestClient(Url);
        }

        private static string Url => "https://shikimori.org/api/users";

        public Task<IEnumerable<User>> ListUsersAsync(ListParams parameters)
        {
            return MakeRequestAsync<IEnumerable<User>>(parameters);
        }

        public Task<User> GetByIdAsync(GetByIdParams parameters)
        {
            return MakeRequestAsync<User>(parameters);
        }

        public Task<UserInfo> GetInfoAsync(GetInfoParams parameters)
        {
            return MakeRequestAsync<UserInfo>(parameters);
        }

        public Task<UserInfo> GetMyInfoAsync(GetMyInfoParams parameters)
        {
            return MakeRequestAsync<UserInfo>(parameters);
        }

        public Task<IEnumerable<UserInfo>> GetFriendsAsync(GetFriendsParams parameters)
        {
            return MakeRequestAsync<IEnumerable<UserInfo>>(parameters);
        }

        public Task<IEnumerable<Club>> GetClubsAsync(GetClubsParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Club>>(parameters);
        }

        public Task<IEnumerable<Anime>> GetAnimesAsync(GetAnimesParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Anime>>(parameters);
        }

        public Task<IEnumerable<Manga>> GetMangasAsync(GetMangasParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Manga>>(parameters);
        }

        public Task<Favourites> GetFavouritesAsync(GetFavouritesParams parameters)
        {
            return MakeRequestAsync<Favourites>(parameters);
        }

        public Task<IEnumerable<Message>> GetMessagesAsync(GetMessagesParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Message>>(parameters);
        }

        public Task<UnreadMessages> GetUnreadMessagesAsync(GetUnreadMessagesParams parameters)
        {
            return MakeRequestAsync<UnreadMessages>(parameters);
        }

        public Task<UserHistory> GetHistoryAsync(GetHistoryParams parameters)
        {
            return MakeRequestAsync<UserHistory>(parameters);
        }

        public Task<IEnumerable<Ban>> GetBansAsync(GetBansParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Ban>>(parameters);
        }

        public Task<UserVideoReport> GetVideoReportsAsync(GetVideoReportsParams parameters)
        {
            return MakeRequestAsync<UserVideoReport>(parameters);
        }
    }
}