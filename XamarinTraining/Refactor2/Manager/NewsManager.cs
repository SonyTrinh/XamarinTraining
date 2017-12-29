using GalaSoft.MvvmLight.Ioc;
using Refactor2.Model;
using Refactor2.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Refactor2.Manager
{
    public class NewsManager : BaseManager
    {
        private readonly IServiceManager _serviceManager;

        public NewsManager(IServiceManager _serviceManager) : base(_serviceManager)
        {

        }

        public async Task<List<News>> GetNews()
        {
            return await _serviceManager.GetNews();
        }
    }
}
