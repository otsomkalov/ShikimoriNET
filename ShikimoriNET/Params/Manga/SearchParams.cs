using RestSharp;
using ShikimoriNET.Enums;
using ShikimoriNET.Enums.Anime;
using ShikimoriNET.Helpers;
using ShikimoriNET.Params.Base;

namespace ShikimoriNET.Params.Manga
{
    public class SearchParams : BasePaginatedParams
    {
        public Order? Order { get; set; }
        public Kind? Kind { get; set; }
        public Status? Status { get; set; }
        public string Season { get; set; }
        public int? Score { get; set; }
        public Duration? Duration { get; set; }
        public Rating? Rating { get; set; }
        public int[] Genre { get; set; }
        public int[] Studio { get; set; }
        public string[] Franchise { get; set; }
        public bool? Censored { get; set; }
        public StatusInList? StatusInList { get; set; }
        public int[] Ids { get; set; }
        public int[] ExcludeIds { get; set; }
        public string Search { get; set; }

        public override IRestRequest GetRequest()
        {
            var request = base.GetRequest();

            if (Order.HasValue) request.AddQueryParameter("order", AttributeHelpers.GetParamAttributeData(Order));
            if (Kind.HasValue) request.AddQueryParameter("kind", AttributeHelpers.GetParamAttributeData(Kind));
            if (Status.HasValue) request.AddQueryParameter("status", AttributeHelpers.GetParamAttributeData(Status));
            if (!string.IsNullOrEmpty(Season)) request.AddQueryParameter("season", Season);
            if (Score.HasValue) request.AddQueryParameter("score", Score.Value.ToString());
            if (Duration.HasValue) request.AddQueryParameter("duration", AttributeHelpers.GetParamAttributeData(Duration));
            if (Rating.HasValue) request.AddQueryParameter("rating", AttributeHelpers.GetParamAttributeData(Rating));
            if (Genre != null) request.AddQueryParameter("genre", string.Join(",", Genre));
            if (Studio != null) request.AddQueryParameter("studio", string.Join(",", Studio));
            if (Franchise != null) request.AddQueryParameter("franchise", string.Join(",", Franchise));
            if (Censored.HasValue) request.AddQueryParameter("censored", Censored.Value.ToString());
            if (StatusInList.HasValue)
                request.AddQueryParameter("mylist", AttributeHelpers.GetParamAttributeData(StatusInList));
            if (Ids != null) request.AddQueryParameter("ids", string.Join(",", Ids));
            if (ExcludeIds != null) request.AddQueryParameter("exclude_ids", string.Join(",", ExcludeIds));
            if (!string.IsNullOrEmpty(Search)) request.AddQueryParameter("search", Search);

            return request;
        }
    }
}