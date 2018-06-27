using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using RIMIKS.Configuration;

namespace RIMIKS.Web.Host.Startup
{
    [DependsOn(
       typeof(RIMIKSWebCoreModule))]
    public class RIMIKSWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public RIMIKSWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(RIMIKSWebHostModule).GetAssembly());
        }
    }
}
