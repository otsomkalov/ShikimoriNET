using System.Collections.Generic;
using System.Threading.Tasks;
using ShikimoriNET.Models;
using ShikimoriNET.Models.Anime;
using ShikimoriNET.Models.Ban;
using ShikimoriNET.Models.Club;
using ShikimoriNET.Models.Manga;
using ShikimoriNET.Models.Message;
using ShikimoriNET.Models.User;
using ShikimoriNET.Params.User;

namespace ShikimoriNET.Categories.Interfaces
{
    public interface IUserCategory
    {
        Task<IEnumerable<User>> ListUsersAsync(ListParams parameters);
        Task<User> GetByIdAsync(GetByIdParams parameters);
        Task<UserInfo> GetInfoAsync(GetInfoParams parameters);
        Task<UserInfo> GetMyInfoAsync(GetMyInfoParams parameters);
        Task<IEnumerable<UserInfo>> GetFriendsAsync(GetFriendsParams parameters);
        Task<IEnumerable<Club>> GetClubsAsync(GetClubsParams parameters);
        Task<IEnumerable<Anime>> GetAnimesAsync(GetAnimesParams parameters);
        Task<IEnumerable<Manga>> GetMangasAsync(GetMangasParams parameters);
        Task<Favourites> GetFavouritesAsync(GetFavouritesParams parameters);
        Task<IEnumerable<Message>> GetMessagesAsync(GetMessagesParams parameters);
        Task<UnreadMessages> GetUnreadMessagesAsync(GetUnreadMessagesParams parameters);
        Task<UserHistory> GetHistoryAsync(GetHistoryParams parameters);
        Task<IEnumerable<Ban>> GetBansAsync(GetBansParams parameters);
        Task<UserVideoReport> GetVideoReportsAsync(GetVideoReportsParams parameters);
    }
}