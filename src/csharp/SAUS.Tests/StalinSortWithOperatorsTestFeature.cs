namespace SAUS.Tests;
[Label("FEAT-3")]
[FeatureDescription(
@"In order to ensure that the StalinSortWithOperators algorithm behaves as expected,
As a developer,
I want to verify that calling StalinSortWithOperators on an array returns a sorted array with out-of-order elements removed")]
public partial class StalinSortWithOperatorsTestFeature
{
    [Label("SCENARIO-STALINOP-1")]
    [Scenario]
    public async Task StalinSortWithOperators_removes_out_of_order_elements()
    {
        await Runner.RunScenarioAsync(
            _=> Given_an_array_with_values(3, 1, 2, 5, 4, 6),
            _=> When_StalinSortWithOperators_is_called(),
            _=> Then_the_result_should_be(new int[] { 3, 5, 6 })
        );
    }

    [Label("SCENARIO-STALINOP-2")]
    [Scenario]
    public async Task StalinSortWithOperators_returns_same_array_if_sorted()
    {
        await Runner.RunScenarioAsync(
            _=> Given_an_array_with_values(1, 2, 3, 4, 5),
            _=> When_StalinSortWithOperators_is_called(),
            _=> Then_the_result_should_be(new int[] { 1, 2, 3, 4, 5 })
        );
    }

    [Label("SCENARIO-STALINOP-3")]
    [Scenario]
    public async Task StalinSortWithOperators_returns_empty_for_empty_array()
    {
        await Runner.RunScenarioAsync(
            _=> Given_an_array_with_values(),
            _=> When_StalinSortWithOperators_is_called(),
            _=> Then_the_result_should_be_empty()
        );
    }

    [Label("SCENARIO-STALINOP-4")]
    [Scenario]
    public async Task StalinSortWithOperators_two_elements_last_remains()
    {
        await Runner.RunScenarioAsync(
            _=> Given_an_array_with_values(5, 3),
            _=> When_StalinSortWithOperators_is_called(),
            _=> Then_the_result_should_be(new int[] { 5 })
        );
    }
}
