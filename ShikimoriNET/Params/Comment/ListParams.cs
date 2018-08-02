using RestSharp;
using ShikimoriNET.Enums.Comment;
using ShikimoriNET.Helpers;
using ShikimoriNET.Params.Base;

namespace ShikimoriNET.Params.Comment
{
    public class ListParams : BasePaginatedParams
    {
        public int CommentableId { get; set; }
        public Kind Kind { get; set; }
        public int? Descending { get; set; }

        public override IRestRequest GetRequest()
        {
            var request = base.GetRequest();

            request.AddQueryParameter("kind", AttributeHelpers.GetParamAttributeData(Kind));
            if (Descending.HasValue) request.AddQueryParameter("desc", Descending.Value.ToString());

            return request;
        }
    }
}