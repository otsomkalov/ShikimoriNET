using RestSharp;

namespace ShikimoriNET.Params.Character
{
    public class SearchParams : IParams
    {
        public int Id { get; set; }

        public virtual IRestRequest GetRequest()
        {
            return new RestRequest("search");
        }
    }
}