using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RIMIKS.Authorization;

namespace RIMIKS
{
    [DependsOn(
        typeof(RIMIKSCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class RIMIKSApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<RIMIKSAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(RIMIKSApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
