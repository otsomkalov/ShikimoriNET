using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using ShikimoriNET.Categories.Interfaces;
using ShikimoriNET.Models.Topic;
using ShikimoriNET.Params.Topic;

namespace ShikimoriNET.Categories
{
    internal class TopicCategory : BaseCategory, ITopicCategory
    {
        public TopicCategory()
        {
            Client = new RestClient(Url);
        }

        private static string Url => "https://shikimori.org/api/topics";

        public Task<IEnumerable<Topic>> ListAsync(ListParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Topic>>(parameters);
        }

        public Task<Topic> GetByIdAsync(GetByIdParams parameters)
        {
            return MakeRequestAsync<Topic>(parameters);
        }
    }
}