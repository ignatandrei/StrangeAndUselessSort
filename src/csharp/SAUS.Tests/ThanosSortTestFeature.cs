namespace SAUS.Tests;
[Label("FEAT-THANOS")]
[FeatureDescription(
@"In order to ensure that the ThanosSort algorithm behaves as expected,
As a developer,
I want to verify that calling ThanosSort on an array randomly eliminates elements until the array is sorted")]
public partial class ThanosSortTestFeature
{
    [Label("SCENARIO-THANOS-1")]
    [Scenario]
    public async Task ThanosSort_returns_sorted_subarray()
    {
        await Runner.RunScenarioAsync(
            _=> Given_an_array_with_values(3, 1, 2, 5, 4, 6),
            _=> When_ThanosSort_is_called(),
            _=> Then_the_result_should_be(3)
        );
    }

    [Label("SCENARIO-THANOS-2")]
    [Scenario]
    public async Task ThanosSort_returns_same_array_if_sorted()
    {
        await Runner.RunScenarioAsync(
            _=> Given_an_array_with_values(1, 2, 3, 4, 5),
            _=> When_ThanosSort_is_called(),
            _=> Then_the_result_should_be(new int[] { 1, 2, 3, 4, 5 })
        );
    }

    [Label("SCENARIO-THANOS-3")]
    [Scenario]
    public async Task ThanosSort_returns_empty_for_empty_array()
    {
        await Runner.RunScenarioAsync(
            _=> Given_an_array_with_values(),
            _=> When_ThanosSort_is_called(),
            _=> Then_the_result_should_be_empty()
        );
    }
    [Label("SCENARIO-THANOS-4")]
    [Scenario]
    public async Task ThanosSort_More_Test_Even()
    {
        await Runner.RunScenarioAsync(
            _ => Given_an_array_with_values(1,  2, 5, 4, 6),
            _ => When_ThanosSort_is_called(),
            _ => Then_the_result_should_be(1,2)
        );
    }
    [Label("SCENARIO-THANOS-5")]
    [Scenario]
    public async Task ThanosSort_More_Test_Odd()
    {
        await Runner.RunScenarioAsync(
            _ => Given_an_array_with_values(1, 2, 5, 4, 6,7),
            _ => When_ThanosSort_is_called(),
            _ => Then_the_result_should_be(1, 2,5)
        );
    }

}
