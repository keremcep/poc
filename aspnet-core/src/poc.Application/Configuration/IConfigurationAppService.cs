using System.Threading.Tasks;
using poc.Configuration.Dto;

namespace poc.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
