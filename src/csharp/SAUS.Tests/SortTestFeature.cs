namespace SAUS.Tests;
[Label("FEAT-1")]
[FeatureDescription(
@"In order to ensure that the HitlerSort algorithm behaves as expected,
As a developer,
I want to verify that calling HitlerSort on a nonempty array returns an empty array ")]
public partial class SortTestFeature
{
    [Label("SCENARIO-HITLER-1")]
    [Scenario]
    public async Task HitlerSort_returns_empty_for_nonempty_array()
    {
        await Runner.RunScenarioAsync(
            _=> Given_an_array_with_values(1, 2, 3, 4, 5),
            _=> When_HitlerSort_is_called(),
            _=> Then_the_result_should_be_empty()
        );
    }

    
}