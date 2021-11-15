using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using poc.Configuration.Dto;

namespace poc.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : pocAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
