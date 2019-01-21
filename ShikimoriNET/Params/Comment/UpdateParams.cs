using RestSharp;
using ShikimoriNET.DTO;

namespace ShikimoriNET.Params.Comment
{
    public class UpdateParams : IParams
    {
        public CommentDTO Comment { get; set; }
        public bool Frontend { get; set; }

        public IRestRequest GetRequest()
        {
            return new RestRequest(Method.PUT)
                .AddJsonBody(this);
        }
    }
}