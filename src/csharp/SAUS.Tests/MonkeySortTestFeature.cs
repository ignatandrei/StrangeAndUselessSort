namespace SAUS.Tests;
[Label("FEAT-MONKEY")]
[FeatureDescription(
@"In order to ensure that the MonkeySort algorithm behaves as expected,
As a developer,
I want to verify that calling MonkeySort on an array randomly shuffles until sorted, returning a sorted array.")]
public partial class MonkeySortTestFeature
{
    [Label("SCENARIO-MONKEY-1")]
    [Scenario]
    public async Task MonkeySort_sorts_unsorted_array()
    {
        await Runner.RunScenarioAsync(
            _=> Given_an_array_with_values(3, 1, 2, 5, 4, 6),
            _=> When_MonkeySort_is_called(),
            _=> Then_the_result_should_be(new int[] { 1, 2, 3, 4, 5, 6 })
        );
    }

    [Label("SCENARIO-MONKEY-2")]
    [Scenario]
    public async Task MonkeySort_returns_same_array_if_sorted()
    {
        await Runner.RunScenarioAsync(
            _=> Given_an_array_with_values(1, 2, 3, 4, 5),
            _=> When_MonkeySort_is_called(),
            _=> Then_the_result_should_be(new int[] { 1, 2, 3, 4, 5 })
        );
    }

    [Label("SCENARIO-MONKEY-3")]
    [Scenario]
    public async Task MonkeySort_returns_empty_for_empty_array()
    {
        await Runner.RunScenarioAsync(
            _=> Given_an_array_with_values(),
            _=> When_MonkeySort_is_called(),
            _=> Then_the_result_should_be_empty()
        );
    }

    [Label("SCENARIO-MONKEY-4")]
    [Scenario]
    public async Task MonkeySort_single_element_array()
    {
        await Runner.RunScenarioAsync(
            _=> Given_an_array_with_values(42),
            _=> When_MonkeySort_is_called(),
            _=> Then_the_result_should_be(new int[] { 42 })
        );
    }
    [Label("SCENARIO-MONKEY-5")]
    [Scenario]
    public async Task MonkeySort_array_with_2_elements()
    {
        await Runner.RunScenarioAsync(
            _ => Given_an_array_with_values(42,34),
            _ => When_MonkeySort_is_called(),
            _ => Then_the_result_should_be(new int[] { 34,42 })
        );
    }
}
