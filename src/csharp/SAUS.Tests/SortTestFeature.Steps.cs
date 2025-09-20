namespace SAUS.Tests;
public partial class SortTestFeature : FeatureFixture
{
    private int[]? inputArray;
    private int[]? resultArray;

    private async Task Given_an_array_with_values(params int[] values)
    {
        await Task.Yield();
        inputArray = values;
        
    }

    private async Task  When_HitlerSort_is_called()
    {
        await Task.Yield();
        resultArray = StrangeAndUselessSort.SortMethods.HitlerSort(inputArray!);
    }

    private async Task Then_the_result_should_be_empty()
    {
        await Assert.That(resultArray).IsNotNull();
        await Assert.That(resultArray!.Length).IsEqualTo(0);
    }
}