using RestSharp;
using ShikimoriNET.Helpers;
using ShikimoriNET.Params.Base;

namespace ShikimoriNET.Params.Topic
{
    public class ListParams : BasePaginatedParams
    {
        public Enums.Topic.Forum Forum { get; set; }

        public override IRestRequest GetRequest()
        {
            var request = base.GetRequest();

            request.AddQueryParameter("forum", AttributeHelpers.GetParamAttributeData(Forum));

            return request;
        }
    }
}