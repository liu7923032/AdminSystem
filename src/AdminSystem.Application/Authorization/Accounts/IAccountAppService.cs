using System.Threading.Tasks;
using Abp.Application.Services;
using AdminSystem.Authorization.Accounts.Dto;

namespace AdminSystem.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
