using RestSharp;
using ShikimoriNET.DTO;

namespace ShikimoriNET.Params.Comment
{
    public class CreateParams : IParams
    {
        public bool Broadcast { get; set; }
        public CommentDTO Comment { get; set; }
        public bool Frontend { get; set; }

        public IRestRequest GetRequest()
        {
            return new RestRequest(Method.POST)
                .AddBody(this);
        }
    }
}