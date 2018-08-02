using RestSharp;
using ShikimoriNET.DTO;
using ShikimoriNET.Params;

namespace ShikimoriNET.Models.Club
{
    public class UpdateParams : IParams
    {
        public int Id { get; set; }
        public ClubDTO Club { get; set; }

        public virtual IRestRequest GetRequest()
        {
            return new RestRequest("{id}").AddUrlSegment("id", Id.ToString()).AddBody(Club);
        }
    }
}