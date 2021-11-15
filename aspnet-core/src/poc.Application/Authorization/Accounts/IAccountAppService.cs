using System.Threading.Tasks;
using Abp.Application.Services;
using poc.Authorization.Accounts.Dto;

namespace poc.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
