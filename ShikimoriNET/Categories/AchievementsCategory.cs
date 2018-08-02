using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using ShikimoriNET.Categories.Interfaces;
using ShikimoriNET.Models.Achievement;
using ShikimoriNET.Params.Achievements;

namespace ShikimoriNET.Categories
{
    public class AchievementsCategory : BaseCategory, IAchievementsCategory
    {
        public AchievementsCategory()
        {
            Client = new RestClient(Url);
        }

        private static string Url => "https://shikimori.org/api/animes";

        public Task<IEnumerable<Achievement>> GetByUserIdAsync(GetAchievementsParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Achievement>>(parameters);
        }
    }
}