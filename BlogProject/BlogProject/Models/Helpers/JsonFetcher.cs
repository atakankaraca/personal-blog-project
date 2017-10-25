using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace BlogTemp.Models
{
    public class JsonFetcher
    {
        public string GetJson(string domain, string query)
        {
            var client = new RestClient(domain);
            var request = new RestRequest(query, Method.GET);
            request.RequestFormat = DataFormat.Json;

            var response = client.Execute(request);

                var content = response.Content;
                return content;
        }
    }
}