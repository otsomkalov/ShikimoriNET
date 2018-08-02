using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using ShikimoriNET.Categories.Interfaces;
using ShikimoriNET.Models.Person;
using ShikimoriNET.Params.People;

namespace ShikimoriNET.Categories
{
    internal class PeopleCategory : BaseCategory, IPeopleCategory
    {
        public PeopleCategory()
        {
            Client = new RestClient(Url);
        }

        private static string Url => "https://shikimori.org/api/people";

        public Task<Person> GetByIdAsync(GetByIdParams parameters)
        {
            return MakeRequestAsync<Person>(parameters);
        }

        public Task<IEnumerable<Person>> SearchAsync(SearchParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Person>>(parameters);
        }
    }
}