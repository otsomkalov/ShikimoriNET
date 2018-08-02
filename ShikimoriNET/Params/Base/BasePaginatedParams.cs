using RestSharp;

namespace ShikimoriNET.Params.Base
{
    public abstract class BasePaginatedParams : IParams
    {
        public int? Page { get; set; }
        public int? Limit { get; set; }

        public virtual IRestRequest GetRequest()
        {
            var request = new RestRequest();

            if (Page.HasValue) request.AddQueryParameter("page", Page.Value.ToString());
            if (Limit.HasValue) request.AddQueryParameter("limit", Limit.Value.ToString());

            return request;
        }
    }
}