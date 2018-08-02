using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using ShikimoriNET.Categories.Interfaces;
using ShikimoriNET.Models.Calendar;

namespace ShikimoriNET.Categories
{
    public class CalendarCategory : BaseCategory, ICalendarCategory
    {
        public CalendarCategory()
        {
            Client = new RestClient(Url);
        }

        private static string Url => "https://shikimori.org/api/calendar";

        public Task<IEnumerable<Event>> GetEventsAsync()
        {
            return MakeRequestAsync<IEnumerable<Event>>();
        }
    }
}