using System.Net;
using System.Threading.Tasks;
using RestSharp;
using ShikimoriNET.Exceptions;
using ShikimoriNET.Params;

namespace ShikimoriNET.Categories
{
    public class BaseCategory
    {
        protected RestClient Client;

        protected async Task MakeRequestAsync()
        {
            var request = new RestRequest();
            await Client.ExecuteTaskAsync(request);
        }

        protected async Task MakeRequestAsync(IParams parameters)
        {
            var request = parameters.GetRequest();
            var response = await Client.ExecuteTaskAsync(request);

            switch (response.StatusCode)
            {
                case HttpStatusCode.Unauthorized:
                    throw new NotAuthorizedException(response.StatusDescription);
            }
        }

        protected async Task<T> MakeRequestAsync<T>()
        {
            var request = new RestRequest();

            var response = await Client.ExecuteTaskAsync<T>(request);

            return response.Data;
        }

        protected async Task<T> MakeRequestAsync<T>(IParams parameters)
        {
            var request = parameters.GetRequest();

            var response = await Client.ExecuteTaskAsync<T>(request);

            return response.Data;
        }
    }
}