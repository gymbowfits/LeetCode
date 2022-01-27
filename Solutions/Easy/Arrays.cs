using System;
using System.Collections.Generic;

namespace LeetCode.Solutions.Easy;

public static class Arrays
{
    // 1. Two Sum
    public static int[] TwoSum_1(int[] nums, int target)
    {
        var d = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (d.TryGetValue(target - nums[i], out var value))
            {
                return new[] { value, i };
            }
            else
            {
                if (!d.ContainsKey(nums[i]))
                {
                    d.Add(nums[i], i);
                }
            }
        }

        return new int[2];
    }

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

    // 36. Valid Sudoko
    public static bool IsValidSudoku_36(char[][] board)
    {
        for (var i = 0; i < board.Length; i++)
        {
            var row = new HashSet<char>(board.Length);
            var column = new HashSet<char>(board.Length);
            var square = new HashSet<char>(board.Length);

            for (var j = 0; j < board.Length; j++)
            {
                // check if the value already exists in the row and is not a blank
                if (row.TryGetValue(board[i][j], out var value) && (value != '.'))
                {
                    return false;
                }

                row.Add(board[i][j]);

                // check if the value already exists in the column and is not a blank
                if (column.TryGetValue(board[j][i], out value) && (value != '.'))
                {
                    return false;
                }

                column.Add(board[j][i]);

                // check if the value already exists in the square and is not a blank
                var r = ((i / 3) * 3) + (j / 3);
                var c = ((i % 3) * 3) + (j % 3);

                if (square.TryGetValue(board[r][c], out value) && (value != '.'))
                {
                    return false;
                }

                square.Add(board[r][c]);
            }
        }

        return true;
    }

    // 48. Rotate Image
    public static void RotateImage_48(int[][] matrix)
    {
        var n = matrix.Length;

        // rotate from the outer edges in
        for (int i = 0; i < n / 2; i++)
        {
            // adjust for the group of digits we are rotating
            for (int j = i; j < (n - i) - 1; j++)
            {
                var topLeftValue = matrix[i][j];
                matrix[i][j] = matrix[n - 1 - j][i]; // bottom left -> top left
                matrix[n - 1 - j][i] = matrix[n - 1 - i][n - 1 - j]; // bottom right -> bottom left
                matrix[n - 1 - i][n - 1 - j] = matrix[j][n - 1 - i]; // top right -> bottom right
                matrix[j][n - 1 - i] = topLeftValue; // top left -> top right
            }
        }
    }

    // 66. Plus One
    public static int[] PlusOne_66(int[] digits)
    {
        if (digits.Length == 0)
        {
            return digits;
        }

        // loop through all digits from the end
        // if any results in a carry over set that digit to 0 and move on to the next digit
        // otherwise increment that digit and return the array
        for (var i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i] == 9)
            {
                digits[i] = 0;
            }
            else
            {
                digits[i]++;

                return digits;
            }
        }

        // all numbers must be 9 if we have reached this point
        // add an additional digit (1), all other digits will be the default int (0)
        var extendedDigits = new int[digits.Length + 1];
        extendedDigits[0] = 1;

        return extendedDigits;
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

    // 283. Move zeroes
    public static void MoveZeroes_283(int[] nums)
    {
        if (nums.Length <= 1)
        {
            return;
        }

        for (var i = 0; i < nums.Length - 1; i++)
        {
            if (nums[i] != 0)
            {
                continue;
            }

            var j = i + 1;

            while ((j < nums.Length - 1) && (nums[j] == 0))
            {
                j++;
            }

            if (nums[j] != 0)
            {
                nums[i] = nums[j];
                nums[j] = 0;
            }
        }
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
