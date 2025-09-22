namespace SAUS.Tests;
public partial class MonkeySortTestFeature : FeatureFixture
{
    private int[]? inputArray;
    private int[]? resultArray;

    private async Task Given_an_array_with_values(params int[] values)
    {
        await Task.Yield();
        inputArray = values;
    }

    private async Task When_MonkeySort_is_called()
    {
        await Task.Yield();
        resultArray = StrangeAndUselessSort.SortMethods.MonkeySort(inputArray!);
    }

    private async Task Then_the_result_should_be(params int[] expected)
    {
        await Assert.That(resultArray).IsNotNull();
        // Compare both arrays for sorted content and length
        await Assert.That(resultArray!.OrderBy(x => x).ToArray()).IsEquivalentTo(expected.OrderBy(x => x).ToArray());
        await Assert.That(resultArray!.Length).IsEqualTo(expected.Length);
    }

    private async Task Then_the_result_should_be_empty()
    {
        await Assert.That(resultArray).IsNotNull();
        await Assert.That(resultArray!.Length).IsEqualTo(0);
    }
}
