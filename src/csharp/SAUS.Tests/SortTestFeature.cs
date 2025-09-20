namespace SAUS.Tests;
[Label("FEAT-1")]
[FeatureDescription(
@"In order to 
As a
I want to ")]
public partial class SortTestFeature
{
    [Label("SCENARIO-HITLER-1")]
    [Scenario]
    public void HitlerSort_returns_empty_for_nonempty_array()
    {
        Runner.RunScenarioAsync(
            _=> Given_an_array_with_values(1, 2, 3, 4, 5),
            _=> When_HitlerSort_is_called(),
            _=> Then_the_result_should_be_empty()
        );
    }

    
}