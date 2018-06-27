using System.Threading.Tasks;
using RIMIKS.Configuration.Dto;

namespace RIMIKS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
