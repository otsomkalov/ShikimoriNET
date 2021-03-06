﻿using RestSharp;

namespace ShikimoriNET.Params.Anime
{
    public class GetExternalLinksParams : IParams
    {
        public int Id { get; set; }

        public virtual IRestRequest GetRequest()
        {
            return new RestRequest("{id}/external_links").AddUrlSegment("id", Id.ToString());
        }
    }
}