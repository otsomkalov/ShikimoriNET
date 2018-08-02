using System.Threading.Tasks;
using ShikimoriNET.Categories.Interfaces;
using ShikimoriNET.Params.Appear;

namespace ShikimoriNET.Categories
{
    internal class AppearCategory : BaseCategory, IAppearCategory
    {
        public Task MarkAsReadAsync(MarkAsReadParams parameters)
        {
            return MakeRequestAsync(parameters);
        }
    }
}