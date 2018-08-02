using RestSharp;
using ShikimoriNET.Params.Base;

namespace ShikimoriNET.Params.Club
{
    public class ListParams : BasePaginatedParams
    {
        public string Search { get; set; }

        public override IRestRequest GetRequest()
        {
            var request = base.GetRequest();

            if (!string.IsNullOrEmpty(Search)) request.AddQueryParameter("search", Search);

            return request;
        }
    }
}