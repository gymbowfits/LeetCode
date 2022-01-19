﻿using System;
using System.Collections.Generic;

namespace LeetCode.Solutions.Easy;

public static class Array
{
    // 26. Remove Duplicates from Sorted Array
    public static int RemoveDuplicates_26(int[] nums)
    {
        // simple cases
        if (nums.Length <= 1)
        {
            return nums.Length;
        }

        var currentIndex = 0;

        // traverse the array with 2 pointers (currentIndex, compareIndex)
        // currentIndex is an index for the last distinct value
        // compareIndex is an index for next value to compare
        for (var compareIndex = 1; compareIndex < nums.Length; compareIndex++)
        {
            if (nums[currentIndex] != nums[compareIndex])
            {
                nums[++currentIndex] = nums[compareIndex];
            }
        }

        // return the count rather than the index
        return currentIndex + 1;
    }

    // 121. Best Time to Buy and Sell Stock
    public static int MaxProfit_121(int[] prices)
    {
        // simple cases
        if (prices.Length <= 1)
        {
            return 0;
        }

        var maximumProfit = 0;
        var minimumPrice = prices[0];

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < minimumPrice)
            {
                minimumPrice = prices[i];
            }

            maximumProfit = Math.Max(maximumProfit, prices[i] - minimumPrice);
        }

        return maximumProfit;
    }

    // 122. Best Time to Buy and Sell Stock II
    public static int MaxProfit_122(int[] prices)
    {
        var profit = 0;

        for (var i = 1; i < prices.Length; i++)
        {
            if (prices[i] > prices[i - 1])
            {
                profit += prices[i] - prices[i - 1];
            }
        }

        return profit;
    }

    // 136. Single Number
    public static int SingleNumber_136(int[] nums)
    {
        var s = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            s ^= nums[i]; // XOR
        }

        return s; // all the duplicates should cancel each other out in the XOR, leaving just the missing number
    }

    // 189. Rotate Array
    public static void Rotate_189(int[] nums, int k)
    {
        var n = nums.Length;

        if ((k == 0) || (n <= 1))
        {
            return;
        }

        var res = new int[n];
        for (var i = 0; i < n; i++)
        {
            res[(i + k) % n] = nums[i];
        }

        for (var i = 0; i < n; i++)
        {
            nums[i] = res[i];
        }
    }

    // 217. Contains Duplicate
    public static bool ContainsDuplicate_217(int[] nums)
    {
        // simple cases
        if (nums.Length <= 1)
        {
            return false;
        }

        var values = new HashSet<int>();

        foreach (var i in nums)
        {
            if (!values.Add(i))
            {
                return true;
            }
        }

        return false;
    }

    // 350. Intersection of Two Arrays II
    public static int[] Intersect_350(int[] nums1, int[] nums2)
    {
        if ((nums1.Length == 0) || (nums2.Length == 0))
        {
            return System.Array.Empty<int>();
        }

        System.Array.Sort(nums1);
        System.Array.Sort(nums2);

        var i = 0;
        var j = 0;

        var intersection = new List<int>();

        while ((i < nums1.Length) && (j < nums2.Length))
        {
            if (nums1[i] == nums2[j])
            {
                intersection.Add(nums1[i]);

                i++;
                j++;
            }
            else if (nums1[i] < nums2[j])
            {
                i++;
            }
            else
            {
                j++;
            }
        }

        return intersection.ToArray();
    }
}
