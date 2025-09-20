namespace SAUS.Tests;
public partial class StalinSortWithOperatorsTestFeature : FeatureFixture
{
    private int[]? inputArray;
    private int[]? resultArray;

    private async Task Given_an_array_with_values(params int[] values)
    {
        await Task.Yield();
        inputArray = values;
    }

    private async Task When_StalinSortWithOperators_is_called()
    {
        await Task.Yield();
        resultArray = StrangeAndUselessSort.SortMethods.StalinSortWithOperators(inputArray!);
    }

    private async Task Then_the_result_should_be(int[] expected)
    {
        await Assert.That(resultArray).IsNotNull();
        await Assert.That(resultArray).IsEquivalentTo(expected);
    }

    private async Task Then_the_result_should_be_empty()
    {
        await Assert.That(resultArray).IsNotNull();
        await Assert.That(resultArray!.Length).IsEqualTo(0);
    }
}
