using System.Collections.Generic;
using System.Threading.Tasks;
using ShikimoriNET.Models.Calendar;

namespace ShikimoriNET.Categories.Interfaces
{
    public interface ICalendarCategory
    {
        Task<IEnumerable<Event>> GetEventsAsync();
    }
}