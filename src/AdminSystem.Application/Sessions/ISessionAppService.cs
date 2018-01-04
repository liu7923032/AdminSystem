using System.Threading.Tasks;
using Abp.Application.Services;
using AdminSystem.Sessions.Dto;

namespace AdminSystem.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
