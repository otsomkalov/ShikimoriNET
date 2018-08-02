using System.Collections.Generic;
using System.Threading.Tasks;
using ShikimoriNET.Models;
using ShikimoriNET.Models.Manga;
using ShikimoriNET.Models.Shared;
using ShikimoriNET.Params.Manga;

namespace ShikimoriNET.Categories.Interfaces
{
    public interface IMangaCategory
    {
        /// <summary>
        ///     Поиск аниме по заданным параметрам
        /// </summary>
        /// <param name="parameters">Параметры поиска</param>
        /// <returns>Список найденых аниме</returns>
        Task<IEnumerable<Manga>> SearchAsync(SearchParams parameters);

        /// <summary>
        ///     Получить аниме по id
        /// </summary>
        /// <param name="parameters">Параметры запроса</param>
        /// <returns>Информацию о аниме</returns>
        Task<FullManga> GetByIdAsync(GetByIdParams parameters);

        /// <summary>
        ///     Получить информацию о ролях
        /// </summary>
        /// <param name="parameters">Параметры запроса</param>
        /// <returns>Список ролей</returns>
        Task<IEnumerable<Role>> GetRolesAsync(GetRolesParams parameters);

        /// <summary>
        ///     Получить список похожих аниме
        /// </summary>
        /// <param name="parameters">Параметры запроса</param>
        /// <returns>Список аниме</returns>
        Task<IEnumerable<Manga>> GetSimilarAsync(GetSimilarParams parameters);

        /// <summary>
        ///     Получить список связанных аниме и манги
        /// </summary>
        /// <param name="parameters">Параметры запроса</param>
        /// <returns>Список связанных аниме и манги</returns>
        Task<IEnumerable<Related>> GetRelatedAsync(GetRelatedParams parameters);

        /// <summary>
        ///     Получить информацию о франшизе
        /// </summary>
        /// <param name="parameters">Параметры запроса</param>
        /// <returns>Франшизу</returns>
        Task<Franchise> GetFranchiseAsync(GetFranchiseParams parameters);

        /// <summary>
        ///     Получиться ссылки на связанные ресурсы
        /// </summary>
        /// <param name="parameters">Параметры запроса</param>
        /// <returns>Список связанных ссылок</returns>
        Task<IEnumerable<ExternalLink>> GetExternalLinksAsync(GetExternalLinksParams parameters);
    }
}