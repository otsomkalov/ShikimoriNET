using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using ShikimoriNET.Categories.Interfaces;
using ShikimoriNET.Models.Dialog;
using ShikimoriNET.Params.Dialog;

namespace ShikimoriNET.Categories
{
    internal class DialogCategory : BaseCategory, IDialogCategory
    {
        public DialogCategory()
        {
            Client = new RestClient(Url);
        }

        private static string Url => "https://shikimori.org/api/dialogs";

        public Task<IEnumerable<Dialog>> ListAsync(ListParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Dialog>>(parameters);
        }

        public Task<Dialog> GetById(GetByIdParams parameters)
        {
            return MakeRequestAsync<Dialog>(parameters);
        }

        public Task DeleteAsync(DeleteParams parameters)
        {
            return MakeRequestAsync(parameters);
        }
    }
}