namespace SAUS.Tests;
[Label("FEAT-SLEEPSORT")]
[FeatureDescription(
@"In order to ensure that the SleepSortWithISignedNumber algorithm behaves as expected,
As a developer,
I want to verify that calling SleepSortWithISignedNumber on an array returns a sorted array after sleeping for each value's number of seconds.")]
public partial class SleepSortTestFeature
{
    [Label("SCENARIO-SLEEPSORT-1")]
    [Scenario]
    public async Task SleepSort_sorts_unsorted_array()
    {
        await Runner.RunScenarioAsync(
            _=> Given_an_array_with_values(3, 1, 2, 5, 4, 6),
            _=> When_SleepSortWithISignedNumber_is_called(),
            _=> Then_the_result_should_be(new int[] { 1, 2, 3, 4, 5, 6 })
        );
    }

    [Label("SCENARIO-SLEEPSORT-2")]
    [Scenario]
    public async Task SleepSort_returns_same_array_if_sorted()
    {
        await Runner.RunScenarioAsync(
            _=> Given_an_array_with_values(1, 2, 3, 4, 5),
            _=> When_SleepSortWithISignedNumber_is_called(),
            _=> Then_the_result_should_be(new int[] { 1, 2, 3, 4, 5 })
        );
    }

    [Label("SCENARIO-SLEEPSORT-3")]
    [Scenario]
    public async Task SleepSort_returns_empty_for_empty_array()
    {
        await Runner.RunScenarioAsync(
            _=> Given_an_array_with_values(),
            _=> When_SleepSortWithISignedNumber_is_called(),
            _=> Then_the_result_should_be_empty()
        );
    }

    [Label("SCENARIO-SLEEPSORT-4")]
    [Scenario]
    public async Task SleepSort_single_element_array()
    {
        await Runner.RunScenarioAsync(
            _=> Given_an_array_with_values(42),
            _=> When_SleepSortWithISignedNumber_is_called(),
            _=> Then_the_result_should_be(new int[] { 42 })
        );
    }
    [Label("SCENARIO-SLEEPSORT-5")]
    [Scenario]
    public async Task SleepSort_array_with_2_elements()
    {
        await Runner.RunScenarioAsync(
            _ => Given_an_array_with_values(42,34),
            _ => When_SleepSortWithISignedNumber_is_called(),
            _ => Then_the_result_should_be(new int[] { 34,42 })
        );
    }
}
