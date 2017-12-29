using Refactor2.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor2.Manager
{
    public abstract class BaseManager
    {
        protected readonly IServiceManager ServiceManager;

        protected BaseManager(IServiceManager serviceManager)
        {
            ServiceManager = serviceManager;
        }
    }
}
