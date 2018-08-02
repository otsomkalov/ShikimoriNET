using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using ShikimoriNET.Categories.Interfaces;
using ShikimoriNET.Models.Comment;
using ShikimoriNET.Params.Comment;

namespace ShikimoriNET.Categories
{
    internal class CommentCategory : BaseCategory, ICommentCategory
    {
        public CommentCategory()
        {
            Client = new RestClient(Url);
        }

        private static string Url => "https://shikimori.org/api/comments";

        public Task<Comment> GetByIdAsync(GetByIdParams parameters)
        {
            return MakeRequestAsync<Comment>(parameters);
        }

        public Task<IEnumerable<Comment>> ListAsync(ListParams parameters)
        {
            return MakeRequestAsync<IEnumerable<Comment>>(parameters);
        }

        public Task CreateCommentAsync(CreateParams parameters)
        {
            return MakeRequestAsync(parameters);
        }

        public Task UpdateCommentAsync(UpdateParams parameters)
        {
            return MakeRequestAsync(parameters);
        }

        public Task DeleteCommentAsync(DeleteParams parameters)
        {
            return MakeRequestAsync(parameters);
        }
    }
}