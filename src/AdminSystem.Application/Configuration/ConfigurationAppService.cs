using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AdminSystem.Configuration.Dto;

namespace AdminSystem.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AdminSystemAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
