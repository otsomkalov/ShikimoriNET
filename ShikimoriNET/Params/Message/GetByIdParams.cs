﻿using RestSharp;

namespace ShikimoriNET.Params.Message
{
    public class GetByIdParams : IParams
    {
        public int Id { get; set; }

        public IRestRequest GetRequest()
        {
            return new RestRequest("{id}").AddUrlSegment("id", Id.ToString());
        }
    }
}