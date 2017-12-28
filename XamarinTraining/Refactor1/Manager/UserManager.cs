﻿using Refactor1.Model;
using Refactor1.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor1.Manager
{
    public class UserManager
    {
        private readonly IServiceManager _serviceManager;

        public UserManager(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        public async Task<User> Authenticate(string email,string password)
        {
            return await _serviceManager.Authenticate(email, password);
        }
    }
}
