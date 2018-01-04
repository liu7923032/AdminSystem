using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AdminSystem.Roles.Dto;
using AdminSystem.Users.Dto;

namespace AdminSystem.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
