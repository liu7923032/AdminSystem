using Abp.AspNetCore.Mvc.ViewComponents;

namespace AdminSystem.Web.Views
{
    public abstract class AdminSystemViewComponent : AbpViewComponent
    {
        protected AdminSystemViewComponent()
        {
            LocalizationSourceName = AdminSystemConsts.LocalizationSourceName;
        }
    }
}
