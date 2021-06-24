using Roof.Core.Models.Response;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft;
using RestSharp;
using Roof.Core.Models.Application;
using Roof.Core;

namespace Roof.Service
{
    public class LoginService
    {
        Configuration _appConfiguration;
        public LoginService(Configuration appConfiguration)
        {
            _appConfiguration = appConfiguration;
        }
        public Token Login(GrantInfo authInfo)
        {
            try
            {
                IRestClient client = new RestClient(_appConfiguration.AuthInfo.token_url);
                RestRequest request = new RestRequest(Method.POST);
                request.AddHeader("content-type", "application/json");
                request.AddParameter("application/json", Newtonsoft.Json.JsonConvert.SerializeObject(authInfo), ParameterType.RequestBody);
                var response = client.Post<Token>(request);
                return response.Data;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
