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

    /// <summary>
    /// ThanosSort: Eliminates the second half of the array until the array is sorted or empty.
    /// Always keeps the first half in each iteration.
    /// </summary>
    public static T[] ThanosSort<T>(T[] input) where T : IComparable<T>
    {
        if (input == null || input.Length == 0)
            return Array.Empty<T>();
        var arr = input.ToArray();
        while (!IsSorted(arr) && arr.Length > 0)
        {
            int half = arr.Length / 2;
            arr = arr.Take(half).ToArray();
        }
        return arr;
    }

    /// <summary>
    /// ThanosSortWithOperators: Same behavior as ThanosSort but relies on generic math operators.
    /// Eliminates the second half of the array until the array is sorted or empty.
    /// </summary>
    public static T[] ThanosSortWithOperators<T>(T[] input) where T : System.Numerics.IComparisonOperators<T, T, bool>
    {
        if (input == null || input.Length == 0)
            return Array.Empty<T>();
        var arr = input.ToArray();
        while (!IsSortedOps(arr) && arr.Length > 0)
        {
            int half = arr.Length / 2;
            arr = arr.Take(half).ToArray();
        }
        return arr;
    }

    /// <summary>
    /// MonkeySort: Randomly shuffles the array until it is sorted.
    /// Returns the sorted array.
    /// </summary>
    public static T[] MonkeySort<T>(T[] input) where T : IComparable<T>
    {
        if (input == null || input.Length == 0)
            return Array.Empty<T>();
        var arr = input.ToArray();
        var rng = new Random();
        int attempts = 0;
        while (!IsSorted(arr))
        {
            // Fisher-Yates shuffle
            for (int i = arr.Length - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
            attempts++;
            // Optional: Prevent infinite loop for huge arrays
            //if (attempts > 1000000) break;
        }
        return arr;
    }

    private static bool IsSorted<T>(T[] arr) where T : IComparable<T>
    {
        if (arr is null) return true;
        if (arr.Length < 2) return true;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i - 1].CompareTo(arr[i]) > 0)
                return false;
        }
        return true;
    }

    private static bool IsSortedOps<T>(T[] arr) where T : System.Numerics.IComparisonOperators<T, T, bool>
    {
        if(arr is null) return true;
        if (arr.Length < 2) return true;
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i - 1] > arr[i])
                return false;
        }
        return true;
    }
}
