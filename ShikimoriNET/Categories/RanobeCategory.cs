using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using ShikimoriNET.Categories.Interfaces;
using ShikimoriNET.Models;
using ShikimoriNET.Models.Ranobe;
using ShikimoriNET.Models.Shared;
using ShikimoriNET.Params.Ranobe;

namespace ShikimoriNET.Categories
{
    internal class RanobeCategory : BaseCategory, IRanobeCategory
    {
        public RanobeCategory()
        {
            Client = new RestClient(Url);
        }

        private static string Url => "https://shikimori.org/api/ranobe";

        public Task<IEnumerable<Ranobe>> SearchAsync(SearchParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Ranobe>>(parameters);
        }

        public Task<Ranobe> GetByIdAsync(GetByIdParams parameters)
        {
            return MakeRequestAsync<Ranobe>(parameters);
        }

        public Task<IEnumerable<Role>> GetRolesAsync(GetRolesParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Role>>(parameters);
        }

        public Task<IEnumerable<Ranobe>> GetSimilarAsync(GetSimilarParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Ranobe>>(parameters);
        }

        public Task<IEnumerable<Related>> GetRelatedAsync(GetRelatedParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Related>>(parameters);
        }

        public Task<Franchise> GetFranchiseAsync(GetFranchiseParams parameters)
        {
            return MakeRequestAsync<Franchise>(parameters);
        }

        public Task<IEnumerable<ExternalLink>> GetExternalLinksAsync(GetExternalLinksParams parameters)
        {
            return MakeRequestAsync<IEnumerable<ExternalLink>>(parameters);
        }
    }
}