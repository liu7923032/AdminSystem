using System.Collections.Generic;
using AdminSystem.Roles.Dto;
using AdminSystem.Users.Dto;

namespace AdminSystem.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
