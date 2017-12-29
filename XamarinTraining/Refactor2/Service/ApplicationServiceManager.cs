using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Refactor2.Model;
using Refactor2.Service.Request;
using System.Net.Http;
using Newtonsoft.Json;
using Refactor2.Service.Response;
using Refactor2.Service.Interface;

namespace Refactor2.Service
{
    public class ApplicationServiceManager : BaseServiceManager, IServiceManager
    {
        public ApplicationServiceManager(string baseUrl, ILoadingProgressor loadingProgressor, INetworkDetector networkDetector, IParser parser)
            : base(baseUrl, loadingProgressor, networkDetector, parser)
        {
            Client.DefaultRequestHeaders.Add(ApiConstant.DreamKey, ApiConstant.DreamKeyToken);
        }

        public async Task<User> Authenticate(AuthenticationRequest request)
        {
            var response = await InvokeService(HttpMethod.Post, ApiConstant.AuthenticateUrl, request);
            if (response.IsSuccessStatusCode)
            {
                return await Dererialize<User>(response.Content);
            }
            else
            {
                return null;
            }
        }

        public async Task<List<News>> GetNews()
        {
            var response = await InvokeService(HttpMethod.Get, ApiConstant.NewsUrl);
            if (response.IsSuccessStatusCode)
            {
                var responseData = await Dererialize<NewsResponse>(response.Content);
                return responseData != null ? responseData.NewsList : null;
            }
            else
            {
                return null;
            }
        }

        public void SaveToken(string token)
        {
            Client.DefaultRequestHeaders.Add("X-DreamFactory-Session-Token", token);
        }      
    }
}
