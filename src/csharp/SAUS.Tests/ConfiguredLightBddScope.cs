[assembly: Parallelize(Scope = ExecutionScope.MethodLevel)]

namespace SAUS.Tests;
[TestClass]
public class ConfiguredLightBddScope
{
    [AssemblyInitialize]
    public static void Setup(TestContext testContext)
    {
        LightBddScope.Initialize(OnConfigure);

        // code executed before any scenarios
    }

    [AssemblyCleanup]
    public static void Cleanup()
    {
        LightBddScope.Cleanup();

        // code executed after all scenarios
    }

    private static void OnConfigure(LightBddConfiguration configuration)
    {
        configuration
            .ReportWritersConfiguration()
            .AddFileWriter<HtmlReportFormatter>(@"~\Reports\SAUS.html");
    }
}
