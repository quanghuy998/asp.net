using Microsoft.IdentityModel.Logging;
using Newtonsoft.Json;
using QuanLyDaoTao.Web.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDaoTao.Web.Service
{
    public class UserApiClient : IUserApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public UserApiClient(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<string> Authenticate(LoginRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var client = _httpClientFactory.CreateClient();
            Uri uri = new Uri("https://localhost:44336/api/Users/authenticate");
            var response = await client.PostAsync(uri, httpContent);
            var token = await response.Content.ReadAsStringAsync();


            return token;
        }

        public async Task<bool> Register(RegisterRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var client = _httpClientFactory.CreateClient();
            Uri uri = new Uri("https://localhost:44336/api/Users/register");
            var response = await client.PostAsync(uri, httpContent);
            var stringresponse = await response.Content.ReadAsStringAsync();
            Boolean result = Convert.ToBoolean(stringresponse);
            return result;
        }

    }
}
