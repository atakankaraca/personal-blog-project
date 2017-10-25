﻿using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace BlogTemp.Models
{
    public class BlogAuth
    {
        public bool Login(out IDictionary<string,string> cookie)
        {
            var client = new RestClient("http://localhost:61085/token");
            var request = new RestRequest(Method.POST);
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddHeader("authorization", "Basic R29raGFuOjEyMzQ1Ng==");
            request.AddParameter("application/x-www-form-urlencoded", "grant_type=password&username=atakan&password=123987", ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                cookie = response.Cookies.ToDictionary(x => x.Name, x => x.Value);
                return true;
            }
            else
            {
                cookie = null;
                return false;
            }
        }
    }
}