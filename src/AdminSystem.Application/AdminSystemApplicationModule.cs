using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AdminSystem.Authorization;

namespace AdminSystem
{
    [DependsOn(
        typeof(AdminSystemCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AdminSystemApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AdminSystemAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AdminSystemApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
