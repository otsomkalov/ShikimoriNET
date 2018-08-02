using ShikimoriNET.Categories;
using ShikimoriNET.Categories.Interfaces;

namespace ShikimoriNET
{
    public class ShikimoriApi
    {
        public readonly IAchievementsCategory Achievement = new AchievementsCategory();
        public readonly IAnimeCategory Anime = new AnimeCategory();
        public readonly IAppearCategory Appear = new AppearCategory();
        public readonly IAuthorizeCategory Authorization = new AuthorizeCategory();
        public readonly IBanCategory Bans = new BanCategory();
        public readonly ICalendarCategory Calendar = new CalendarCategory();
        public readonly ICharacterCategory Character = new CharacterCategory();
        public readonly IClubCategory Club = new ClubCategory();
        public readonly ICommentCategory Comment = new CommentCategory();
        public readonly IDeviceCategory Device = new DeviceCategory();
        public readonly IDialogCategory Dialog = new DialogCategory();
        public readonly IForumCategory Forum = new ForumCategory();
        public readonly IFriendCategory Friend = new FriendCategory();
        public readonly IMangaCategory Manga = new MangaCategory();
        public readonly IMessageCategory Message = new MessageCategory();
        public readonly IPeopleCategory People = new PeopleCategory();
        public readonly IPublisherCategory Publisher = new PublisherCategory();
        public readonly IRanobeCategory Ranobe = new RanobeCategory();
        public readonly ISessionCategory Session = new SessionCategory();
        public readonly IStatCategory Stat = new StatCategory();
        public readonly IStudioCategory Studio = new StudioCategory();
        public readonly IStyleCategory Style = new StyleCategory();
        public readonly ITopicCategory Topic = new TopicCategory();
        public readonly IUserCategory User = new UserCategory();
        public readonly IUserImageCategory UserImage = new UserImageCategory();
        public readonly IUserRateCategory UserRate = new UserRateCategory();
        public readonly IVideoCategory Video = new VideoCategory();
    }
}