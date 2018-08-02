using System.Collections.Generic;
using System.Threading.Tasks;
using ShikimoriNET.Models.Achievement;
using ShikimoriNET.Params.Achievements;

namespace ShikimoriNET.Categories.Interfaces
{
    public interface IAchievementsCategory
    {
        Task<IEnumerable<Achievement>> GetByUserIdAsync(GetAchievementsParams parameters);
    }
}