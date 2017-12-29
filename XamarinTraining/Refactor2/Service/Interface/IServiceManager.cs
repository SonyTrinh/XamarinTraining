using Refactor2.Model;
using Refactor2.Service.Request;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Refactor2.Service
{
    public interface IServiceManager
    {
        Task<User> Authenticate(AuthenticationRequest request);

        Task<List<News>> GetNews();

        void SaveToken(string token);
    }
}
