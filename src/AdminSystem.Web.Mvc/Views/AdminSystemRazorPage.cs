using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace AdminSystem.Web.Views
{
    public abstract class AdminSystemRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected AdminSystemRazorPage()
        {
            LocalizationSourceName = AdminSystemConsts.LocalizationSourceName;
        }
    }
}
