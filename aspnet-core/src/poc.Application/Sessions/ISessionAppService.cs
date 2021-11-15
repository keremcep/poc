using System.Threading.Tasks;
using Abp.Application.Services;
using poc.Sessions.Dto;

namespace poc.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
