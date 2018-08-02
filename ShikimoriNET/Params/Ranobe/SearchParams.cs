using System.Collections.Generic;
using RestSharp;
using ShikimoriNET.Enums;
using ShikimoriNET.Enums.Ranobe;
using ShikimoriNET.Helpers;
using ShikimoriNET.Params.Base;

namespace ShikimoriNET.Params.Ranobe
{
    public class SearchParams : BasePaginatedParams
    {
        public Order? Order { get; set; }
        public Status? Status { get; set; }
        public string Season { get; set; }
        public decimal? Score { get; set; }
        public IEnumerable<int> Genre { get; set; }
        public IEnumerable<int> Studio { get; set; }
        public IEnumerable<string> Franchise { get; set; }
        public bool? Censored { get; set; }
        public StatusInList? MyList { get; set; }
        public IEnumerable<int> Ids { get; set; }
        public IEnumerable<int> ExcludeIds { get; set; }
        public string Search { get; set; }

        public override IRestRequest GetRequest()
        {
            var request = base.GetRequest();

            if (Order.HasValue) request.AddQueryParameter("order", AttributeHelpers.GetParamAttributeData(Order));
            if (Status.HasValue) request.AddQueryParameter("status", AttributeHelpers.GetParamAttributeData(Status));
            if (!string.IsNullOrEmpty(Season)) request.AddQueryParameter("season", Season);
            if (Score.HasValue) request.AddQueryParameter("score", Score.Value.ToString());
            if (Genre != null) request.AddQueryParameter("genre", string.Join(",", Genre));
            if (Studio != null) request.AddQueryParameter("studio", string.Join(",", Studio));
            if (Franchise != null) request.AddQueryParameter("franchise", string.Join(",", Franchise));
            if (Censored.HasValue) request.AddQueryParameter("censored", Censored.Value.ToString().ToLower());
            if (MyList.HasValue)
                request.AddQueryParameter("mylist", AttributeHelpers.GetParamAttributeData(MyList));
            if (Ids != null) request.AddQueryParameter("ids", string.Join(",", Ids));
            if (ExcludeIds != null) request.AddQueryParameter("exclude_ids", string.Join(",", ExcludeIds));
            if (!string.IsNullOrEmpty(Search)) request.AddQueryParameter("search", Search);

            return request;
        }
    }
}