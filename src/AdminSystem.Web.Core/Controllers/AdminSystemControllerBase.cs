using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AdminSystem.Controllers
{
    public abstract class AdminSystemControllerBase: AbpController
    {
        protected AdminSystemControllerBase()
        {
            LocalizationSourceName = AdminSystemConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
