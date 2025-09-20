using LightBDD.Core.Configuration;
using LightBDD.TUnit;
using LightBDDTests1;
using System.Threading.Tasks;

[assembly: ConfiguredLightBddScope]

namespace LightBDDTests1;
internal class ConfiguredLightBddScopeAttribute : LightBddScopeAttribute
{
    protected override void OnConfigure(LightBddConfiguration configuration)
    {
        // LightBDD configuration
    }

    protected override async ValueTask OnSetUp()
    {
        // code executed before any scenarios
    }

    protected override async ValueTask OnTearDown()
    {
        // code executed after all scenarios
    }
}
