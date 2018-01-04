using System.Threading.Tasks;
using AdminSystem.Configuration.Dto;

namespace AdminSystem.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
