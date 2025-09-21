namespace SAUS.Tests;
public partial class ThanosSortTestFeature : FeatureFixture
{
    private int[]? inputArray;
    private int[]? resultArray;

    private async Task Given_an_array_with_values(params int[] values)
    {
        await Task.Yield();
        inputArray = values;
    }

    private async Task When_ThanosSort_is_called()
    {
        await Task.Yield();
        resultArray = StrangeAndUselessSort.SortMethods.ThanosSort(inputArray ?? Array.Empty<int>());
    }

    private async Task Then_the_result_should_be(params int[] expected)
    {
        await Assert.That(resultArray).IsNotNull();
        await Assert.That(resultArray!.Length).IsEqualTo(expected.Length);
        await Assert.That(resultArray!.SequenceEqual(expected)).IsTrue();
        for (int i = 0; i < expected.Length; i++)
        {
            await Assert.That(resultArray[i]).IsEqualTo(expected[i]);
        }
            for (int i = 1; i < resultArray!.Length; i++)
        {
            await Assert.That(resultArray[i - 1] <= resultArray[i]).IsTrue();
        }
    }

    private async Task Then_the_result_should_be_empty()
    {
        await Assert.That(resultArray).IsNotNull();
        await Assert.That(resultArray!.Length).IsEqualTo(0);
    }


}
