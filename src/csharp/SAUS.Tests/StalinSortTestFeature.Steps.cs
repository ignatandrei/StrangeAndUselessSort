namespace SAUS.Tests;
public partial class StalinSortTestFeature : FeatureFixture
{
    private int[]? inputArray;
    private int[]? resultArray;

    private async Task Given_an_array_with_values(params int[] values)
    {
        await Task.Yield();
        inputArray = values;
    }

    private async Task When_StalinSort_is_called()
    {
        await Task.Yield();
        resultArray = StrangeAndUselessSort.SortMethods.StalinSort(inputArray ?? Array.Empty<int>());
    }

    private async Task Then_the_result_should_be(int[] expected)
    {
        await Assert.That(resultArray).IsNotNull();
        await Assert.That(resultArray!.Length).IsEqualTo(expected.Length);
        await Assert.That(resultArray!.SequenceEqual(expected)).IsTrue();
        for (int i = 0; i < expected.Length; i++)
        {
            await Assert.That(resultArray[i]).IsEqualTo(expected[i]);
        }
    }

    private async Task Then_the_result_should_be_empty()
    {
        await Assert.That(resultArray).IsNotNull();
        await Assert.That(resultArray!.Length).IsEqualTo(0);
    }
}
