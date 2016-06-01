using System.Diagnostics;

public static class BinarySearch
{
    /// <summary>
    ///     1.  Write a listbox-style binary search for an ordered array of integers.  Listbox-style means that you should
    ///     return the index of the first item greater than or equal to the item being searched for; if all items are less, you
    ///     should return the index of the last item.  You are guaranteed that there is at least one item in the array.
    /// </summary>
    /// <param name="arr">Array</param>
    /// <param name="value">Value search for</param>
    /// <returns>Index of first greate or equal item or last index</returns>
    public static int search(int[] arr, int value)
    {
        Debug.Assert(arr.Length>0);
        var left = 0;
        var right = arr.Length - 1;

        while (((right - left)/2) > 0)
        {
            var middle = left + (right - left)/2;
            if (arr[middle] < value)
                left = middle + 1;
            else
                right = middle;
        }
        return arr[left] >= value ? left : right;
    }
}