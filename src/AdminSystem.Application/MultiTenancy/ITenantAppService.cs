using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AdminSystem.MultiTenancy.Dto;

namespace AdminSystem.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
