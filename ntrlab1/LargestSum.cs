using System;
using System.Collections.Generic;

namespace ntrlab1
{
    /// <summary>
    ///     2.  Suppose you have an array of integers, both positive and negative, in no particular order.  Find the largest
    ///     possible sum of any continuous subarray.  For example, if you have all positive numbers, the largest sum would be
    ///     the sum of the whole array; if you have all negative numbers, the largest sum is 0 (the null subarray)
    /// </summary>
    public class LargestSum
    {
        public static int find(int[] arr)
        {
            var arr1 = shrink(arr);
            int best = 0;
            for (int i = 0; i < arr1.Length/2; i++)
            {
                    int sumij = arr1[2*i];
                    best = Math.Max(best, sumij);
                for (int j = i + 1; j < arr1.Length/2; j++)
                {
                    sumij += arr1[2 * j - 1];
                    sumij += arr1[2 * j];
                    best = Math.Max(best, sumij);
                }
            }
            return best;
        }
        /// <summary>
        /// Shrink various array to array of positive, negative, positive, negative, .... items
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] shrink(int[] arr)
        {
            var list = new List<int>();
            int index = 0;
            for (; index < arr.Length && arr[index] <= 0; index++) ;
            while (index < arr.Length)
            {
                int sump = 0;
                for (; index < arr.Length && arr[index] >= 0; index++) sump += arr[index];
                list.Add(sump);
                int sumn = 0;
                for (; index < arr.Length && arr[index] <= 0; index++) sumn += arr[index];
                list.Add(sumn);
            }
            return list.ToArray();
        }
    }
}