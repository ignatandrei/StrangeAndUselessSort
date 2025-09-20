[assembly: ConfiguredLightBddScope]
namespace SAUS.Tests;
internal class ConfiguredLightBddScopeAttribute : LightBddScopeAttribute
{
    protected override void OnConfigure(LightBddConfiguration configuration)
    {
        // LightBDD configuration
        configuration
            .ReportWritersConfiguration()
            .AddFileWriter<HtmlReportFormatter>(@"~\Reports\SAUS.html");
    }
}
