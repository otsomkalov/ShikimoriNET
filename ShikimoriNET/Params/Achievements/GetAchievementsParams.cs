using RestSharp;

namespace ShikimoriNET.Params.Achievements
{
    public class GetAchievementsParams : IParams
    {
        public int UserId { get; set; }

        public virtual IRestRequest GetRequest()
        {
            return new RestRequest("{user_id}").AddUrlSegment("user_id", UserId.ToString());
        }
    }
}