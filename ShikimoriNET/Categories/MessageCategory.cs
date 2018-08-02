using System.Threading.Tasks;
using RestSharp;
using ShikimoriNET.Categories.Interfaces;
using ShikimoriNET.Models.Message;
using ShikimoriNET.Params.Message;

namespace ShikimoriNET.Categories
{
    internal class MessageCategory : BaseCategory, IMessageCategory
    {
        public MessageCategory()
        {
            Client = new RestClient(Url);
        }

        private static string Url => "https://shikimori.org/api/messages";

        public Task<Message> GetByIdAsync(GetByIdParams parameters)
        {
            return MakeRequestAsync<Message>(parameters);
        }

        public Task CreateAsync(CreateParams parameters)
        {
            return MakeRequestAsync(parameters);
        }

        public Task UpdateAsync(UpdateParams parameters)
        {
            return MakeRequestAsync(parameters);
        }

        public Task DeleteAsync(DeleteParams parameters)
        {
            return MakeRequestAsync(parameters);
        }

        public Task MarkAsReadAsync(MarkAsReadParams parameters)
        {
            return MakeRequestAsync(parameters);
        }

        public Task MarkAllAsReadAsync(MarkAllAsReadParams parameters)
        {
            return MakeRequestAsync(parameters);
        }

        public Task DeleteAllAsync(DeleteAllParams parameters)
        {
            return MakeRequestAsync(parameters);
        }
    }
}