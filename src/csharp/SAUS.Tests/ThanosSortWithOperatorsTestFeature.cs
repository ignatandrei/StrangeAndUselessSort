namespace SAUS.Tests;
[Label("FEAT-THANOSOP")]
[FeatureDescription(
@"In order to ensure that the ThanosSort algorithm behaves as expected,
As a developer,
I want to verify that calling ThanosSort on an array array deterministically eliminates elements (e.g., keeps the first half and discards the second half) until the array is sorted")]
public partial class ThanosSortWithOperatorsTestFeature
{
    [Label("SCENARIO-THANOSOP-1")]
    [Scenario]
    public async Task ThanosSortWithOperators_returns_sorted_subarray()
    {
        await Runner.RunScenarioAsync(
            _=> Given_an_array_with_values(3, 1, 2, 5, 4, 6),
            _=> When_ThanosSortWithOperators_is_called(),
            _=> Then_the_result_should_be(3)
        );
    }

    [Label("SCENARIO-THANOSOP-2")]
    [Scenario]
    public async Task ThanosSortWithOperators_returns_same_array_if_sorted()
    {
        await Runner.RunScenarioAsync(
            _=> Given_an_array_with_values(1, 2, 3, 4, 5),
            _=> When_ThanosSortWithOperators_is_called(),
            _=> Then_the_result_should_be(new int[] { 1, 2, 3, 4, 5 })
        );
    }

    [Label("SCENARIO-THANOSOP-3")]
    [Scenario]
    public async Task ThanosSortWithOperators_returns_empty_for_empty_array()
    {
        await Runner.RunScenarioAsync(
            _=> Given_an_array_with_values(),
            _=> When_ThanosSortWithOperators_is_called(),
            _=> Then_the_result_should_be_empty()
        );
    }

    [Label("SCENARIO-THANOSOP-4")]
    [Scenario]
    public async Task ThanosSortWithOperators_More_Test_Even()
    {
        await Runner.RunScenarioAsync(
            _ => Given_an_array_with_values(1,  2, 5, 4, 6),
            _ => When_ThanosSortWithOperators_is_called(),
            _ => Then_the_result_should_be(1,2)
        );
    }

    [Label("SCENARIO-THANOSOP-5")]
    [Scenario]
    public async Task ThanosSortWithOperators_More_Test_Odd()
    {
        await Runner.RunScenarioAsync(
            _ => Given_an_array_with_values(1, 2, 5, 4, 6,7),
            _ => When_ThanosSortWithOperators_is_called(),
            _ => Then_the_result_should_be(1, 2,5)
        );
    }
}
