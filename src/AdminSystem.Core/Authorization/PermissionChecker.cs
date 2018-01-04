using Abp.Authorization;
using AdminSystem.Authorization.Roles;
using AdminSystem.Authorization.Users;

namespace AdminSystem.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
