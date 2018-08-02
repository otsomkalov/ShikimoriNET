using System.Collections.Generic;
using System.Threading.Tasks;
using ShikimoriNET.Models.Person;
using ShikimoriNET.Params.People;

namespace ShikimoriNET.Categories.Interfaces
{
    public interface IPeopleCategory
    {
        Task<Person> GetByIdAsync(GetByIdParams parameters);
        Task<IEnumerable<Person>> SearchAsync(SearchParams parameters);
    }
}