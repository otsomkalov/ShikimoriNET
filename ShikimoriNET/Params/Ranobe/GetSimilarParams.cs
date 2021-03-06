﻿using RestSharp;

namespace ShikimoriNET.Params.Ranobe
{
    public class GetSimilarParams : IParams
    {
        public int Id { get; set; }

        public virtual IRestRequest GetRequest()
        {
            return new RestRequest("{id}/similar").AddUrlSegment("id", Id.ToString());
        }
    }
}