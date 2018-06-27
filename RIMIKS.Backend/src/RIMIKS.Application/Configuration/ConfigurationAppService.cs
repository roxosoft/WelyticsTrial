using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using RIMIKS.Configuration.Dto;

namespace RIMIKS.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : RIMIKSAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
