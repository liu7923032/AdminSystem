using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AdminSystem.Configuration;

namespace AdminSystem.Web.Host.Startup
{
    [DependsOn(
       typeof(AdminSystemWebCoreModule))]
    public class AdminSystemWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AdminSystemWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AdminSystemWebHostModule).GetAssembly());
        }
    }
}
