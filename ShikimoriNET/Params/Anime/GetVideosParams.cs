﻿using RestSharp;

namespace ShikimoriNET.Params.Anime
{
    public class GetVideosParams : IParams
    {
        public int Id { get; set; }

        public IRestRequest GetRequest()
        {
            return new RestRequest("{id}/videos").AddUrlSegment("id", Id.ToString());
        }
    }
}