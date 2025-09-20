namespace StrangeAndUselessSort;

public class SortMethods
{
    /// <summary>
    /// Returns an empty array, regardless of input.
    /// </summary>
    public static T[] HitlerSort<T>(T[] input)
    {
        return Array.Empty<T>();
    }

    /// <summary>
    /// StalinSort: Iterates through the array, removing any element that is out of order.
    /// Returns a sorted array containing only the elements that were in order.
    /// </summary>
    public static T[] StalinSort<T>(T[] input) where T : IComparable<T>
    {
        if (input == null || input.Length == 0)
            return Array.Empty<T>();
        var result = new List<T> { input[0] };
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i].CompareTo(result[^1]) >= 0)
                result.Add(input[i]);
        }
        return result.ToArray();
    }

    /// <summary>
    /// StalinSortWithOperators for types implementing IComparisonOperators. Uses >= operator for comparison.
    /// </summary>
    public static T[] StalinSortWithOperators<T>(T[] input) where T : System.Numerics.IComparisonOperators<T, T, bool>
    {
        if (input == null || input.Length == 0)
            return Array.Empty<T>();
        var result = new List<T> { input[0] };
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] >= result[^1])
                result.Add(input[i]);
        }
        return result.ToArray();
    }
}
