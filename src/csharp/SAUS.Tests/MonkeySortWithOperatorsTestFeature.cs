namespace SAUS.Tests;
[Label("FEAT-MONKEYOP")]
[FeatureDescription(
@"In order to ensure that the MonkeySortWithOperators algorithm behaves as expected,
As a developer,
I want to verify that calling MonkeySortWithOperators on an array randomly shuffles until sorted, returning a sorted array.")]
public partial class MonkeySortWithOperatorsTestFeature
{
    [Label("SCENARIO-MONKEYOP-1")]
    [Scenario]
    public async Task MonkeySortWithOperators_sorts_unsorted_array()
    {
        await Runner.RunScenarioAsync(
            _=> Given_an_array_with_values(3, 1, 2, 5, 4, 6),
            _=> When_MonkeySortWithOperators_is_called(),
            _=> Then_the_result_should_be(new int[] { 1, 2, 3, 4, 5, 6 })
        );
    }

    [Label("SCENARIO-MONKEYOP-2")]
    [Scenario]
    public async Task MonkeySortWithOperators_returns_same_array_if_sorted()
    {
        await Runner.RunScenarioAsync(
            _=> Given_an_array_with_values(1, 2, 3, 4, 5),
            _=> When_MonkeySortWithOperators_is_called(),
            _=> Then_the_result_should_be(new int[] { 1, 2, 3, 4, 5 })
        );
    }

    [Label("SCENARIO-MONKEYOP-3")]
    [Scenario]
    public async Task MonkeySortWithOperators_returns_empty_for_empty_array()
    {
        await Runner.RunScenarioAsync(
            _=> Given_an_array_with_values(),
            _=> When_MonkeySortWithOperators_is_called(),
            _=> Then_the_result_should_be_empty()
        );
    }

    [Label("SCENARIO-MONKEYOP-4")]
    [Scenario]
    public async Task MonkeySortWithOperators_single_element_array()
    {
        await Runner.RunScenarioAsync(
            _=> Given_an_array_with_values(42),
            _=> When_MonkeySortWithOperators_is_called(),
            _=> Then_the_result_should_be(new int[] { 42 })
        );
    }
    [Label("SCENARIO-MONKEYOP-5")]
    [Scenario]
    public async Task MonkeySortWithOperators_array_with_2_elements()
    {
        await Runner.RunScenarioAsync(
            _ => Given_an_array_with_values(42,34),
            _ => When_MonkeySortWithOperators_is_called(),
            _ => Then_the_result_should_be(new int[] { 34,42 })
        );
    }
}
