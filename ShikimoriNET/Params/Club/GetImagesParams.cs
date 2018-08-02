using RestSharp;

namespace ShikimoriNET.Params.Club
{
    public class GetImagesParams : IParams
    {
        public int Id { get; set; }

        public virtual IRestRequest GetRequest()
        {
            return new RestRequest("{id}/images").AddUrlSegment("id", Id.ToString());
        }
    }
}