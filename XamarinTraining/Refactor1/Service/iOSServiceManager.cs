﻿using Newtonsoft.Json;
using Refactor1.Model;
using Refactor1.Service.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Refactor1.Service
{
    public class iOSServiceManager : BaseServiceManager, IServiceManager
    {
        public async Task<User> Authenticate(AuthenticationRequest request)
        {
            var response = await InvokeService(HttpMethod.Post, ApiConstants.Authenticate, request);
            if (response.IsSuccessStatusCode)
            {
                var responseBody = await response.Content.ReadAsStringAsync();
                var user = JsonConvert.DeserializeObject<User>(responseBody);
                return user;
            }
            else
            {
                return null;
            }
        }

        #region iOS platform code
        protected override bool HasNetworkConnection()
        {
            // TODO: Check network connection
            return true;
        }

        protected override void HideLoadingProgress()
        {
            // TODO: Hide Progress Dialog
            Console.WriteLine("Done");
        }

        protected override void ShowLoadingProgress()
        {
            // TODO: Show Progress Dialog
            Console.Write("Loading...");
        }
        #endregion
    }
}
