using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using RIMIKS.Authorization.Roles;
using RIMIKS.Authorization.Users;
using RIMIKS.Configuration;
using RIMIKS.Localization;
using RIMIKS.MultiTenancy;
using RIMIKS.Timing;

namespace RIMIKS
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class RIMIKSCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = false;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            RIMIKSLocalizationConfigurer.Configure(Configuration.Localization);
            Configuration.MultiTenancy.IsEnabled = false;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RIMIKSCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
