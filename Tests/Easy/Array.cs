using System;
using NUnit.Framework;

namespace LeetCode.Tests.Easy;

public class Array
{
    [Test]
    [TestCase(new int[] { 1, 2 }, 3, new int[] { 0, 1 })]
    [TestCase(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [TestCase(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [TestCase(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    [TestCase(new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11, new int[] { 5, 11 })]
    public static void TwoSum_1(int[] nums, int target, int[] expectedResult)
    {
        var result = Solutions.Easy.Array.TwoSum_1(nums, target);

        Assert.That(result, Is.EquivalentTo(expectedResult));
    }

    [Test]
    [TestCase(new int[0], new int[0])]
    [TestCase(new int[] { 1 }, new int[] { 1 })]
    [TestCase(new int[] { 1, 1, 2 }, new int[] { 1, 2 })]
    [TestCase(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, new int[] { 0, 1, 2, 3, 4 })]
    public void RemoveDuplicates_26(int[] nums, int[] expectedNums)
    {
        var result = Solutions.Easy.Array.RemoveDuplicates_26(nums);

        Assert.That(result, Is.EqualTo(expectedNums.Length));

        for (int i = 0; i < result; i++)
        {
            Assert.That(nums[i], Is.EqualTo(expectedNums[i]));
        }
    }

    private static object[] IsValidSudoko_36_Cases =
    {
        new object[]
        {
            new char[][]
            {
                 new char[] { '5','3','.','.','7','.','.','.','.' }
                ,new char[] { '6','.','.','1','9','5','.','.','.' }
                ,new char[] { '.','9','8','.','.','.','.','6','.' }
                ,new char[] { '8','.','.','.','6','.','.','.','3' }
                ,new char[] { '4','.','.','8','.','3','.','.','1' }
                ,new char[] { '7','.','.','.','2','.','.','.','6' }
                ,new char[] { '.','6','.','.','.','.','2','8','.' }
                ,new char[] { '.','.','.','4','1','9','.','.','5' }
                ,new char[] { '.','.','.','.','8','.','.','7','9' }
            },
            true
        },
        new object[]
        {
            new char[][]
            {
                 new char[] { '5','7','.','.','7','.','.','.','.' }
                ,new char[] { '6','.','.','1','9','5','.','.','.' }
                ,new char[] { '.','9','8','.','.','.','.','6','.' }
                ,new char[] { '8','.','.','.','6','.','.','.','3' }
                ,new char[] { '4','.','.','8','.','3','.','.','1' }
                ,new char[] { '7','.','.','.','2','.','.','.','6' }
                ,new char[] { '.','6','.','.','.','.','2','8','.' }
                ,new char[] { '.','.','.','4','1','9','.','.','5' }
                ,new char[] { '.','.','.','.','8','.','.','7','9' }
            },
            false // fail on row
        },
        new object[]
        {
            new char[][]
            {
                 new char[] { '5','3','.','.','7','.','.','.','.' }
                ,new char[] { '7','.','.','1','9','5','.','.','.' }
                ,new char[] { '.','9','8','.','.','.','.','6','.' }
                ,new char[] { '8','.','.','.','6','.','.','.','3' }
                ,new char[] { '4','.','.','8','.','3','.','.','1' }
                ,new char[] { '7','.','.','.','2','.','.','.','6' }
                ,new char[] { '.','6','.','.','.','.','2','8','.' }
                ,new char[] { '.','.','.','4','1','9','.','.','5' }
                ,new char[] { '.','.','.','.','8','.','.','7','9' }
            },
            false // fail on column
        },
        new object[]
        {
            new char[][]
            {
                 new char[] { '8','3','.','.','7','.','.','.','.' }
                ,new char[] { '6','.','.','1','9','5','.','.','.' }
                ,new char[] { '.','9','8','.','.','.','.','6','.' }
                ,new char[] { '8','.','.','.','6','.','.','.','3' }
                ,new char[] { '4','.','.','8','.','3','.','.','1' }
                ,new char[] { '7','.','.','.','2','.','.','.','6' }
                ,new char[] { '.','6','.','.','.','.','2','8','.' }
                ,new char[] { '.','.','.','4','1','9','.','.','5' }
                ,new char[] { '.','.','.','.','8','.','.','7','9' }
            },
            false // fail on square
        }
    };

    [Test]
    [TestCaseSource(nameof(IsValidSudoko_36_Cases))]
    public static void IsValidSudoko_36(char[][] board, bool expectedResult)
    {
        var result = Solutions.Easy.Array.IsValidSudoku_36(board);

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    private static object[] RotateImage_48_Cases =
    {
        new object[] { new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } }, new int[][] { new int[] { 7, 4, 1 }, new int[] { 8, 5, 2 }, new int[] { 9, 6, 3 } } },
        new object[] { new int[][] { new int[] { 5, 1, 9, 11 }, new int[] { 2, 4, 8, 10 }, new int[] { 13, 3, 6, 7 }, new int[] { 15, 14, 12, 16 } }, new int[][] { new int[] { 15, 13, 2, 5 }, new int[] { 14, 3, 4, 1 }, new int[] { 12, 6, 8, 9 }, new int[] { 16, 7, 10, 11 } } }
    };

    [Test]
    [TestCaseSource(nameof(RotateImage_48_Cases))]
    public static void RotateImage_48(int[][] matrix, int[][] expectedMatrix)
    {
        Solutions.Easy.Array.RotateImage_48(matrix);

        Assert.That(matrix, Is.EqualTo(expectedMatrix));
    }

    [Test]
    [TestCase(new int[0], new int[0])]
    [TestCase(new int[] { 1 }, new int[] { 2 })]
    [TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 })]
    [TestCase(new int[] { 4, 3, 2, 1 }, new int[] { 4, 3, 2, 2 })]
    [TestCase(new int[] { 9 }, new int[] { 1, 0 })]
    [TestCase(new int[] { 3, 9 }, new int[] { 4, 0 })]
    public void PlusOne_66(int[] digits, int[] expectedDigits)
    {
        var result = Solutions.Easy.Array.PlusOne_66(digits);

        Assert.That(result, Is.EqualTo(expectedDigits));
    }

    [Test]
    [TestCase(new int[] { 1 }, 0)]
    [TestCase(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
    [TestCase(new int[] { 7, 6, 4, 3, 1 }, 0)]
    [TestCase(new int[] { 1, 7, 3, 10 }, 9)]
    public void MaxProfit_121(int[] prices, int expectedResult)
    {
        var result = Solutions.Easy.Array.MaxProfit_121(prices);

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase(new int[] { 1 }, 0)]
    [TestCase(new int[] { 7, 1, 5, 3, 6, 4 }, 7)]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4)]
    [TestCase(new int[] { 7, 6, 4, 3, 1 }, 0)]
    public void MaxProfit_122(int[] prices, int expectedResult)
    {
        var result = Solutions.Easy.Array.MaxProfit_122(prices);

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase(new int[] { 2, 2, 1 }, 1)]
    [TestCase(new int[] { 4, 1, 2, 1, 2 }, 4)]
    [TestCase(new int[] { 1 }, 1)]
    public void SingleNumber_136(int[] nums, int expectedResult)
    {
        var result = Solutions.Easy.Array.SingleNumber_136(nums);

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, 3, new int[] { 5, 6, 7, 1, 2, 3, 4 })]
    [TestCase(new int[] { -1, -100, 3, 99 }, 2, new int[] { 3, 99, -1, -100 })]
    public void Rotate_189(int[] nums, int k, int[] expectedNums)
    {
        Solutions.Easy.Array.Rotate_189(nums, k);

        Assert.That(nums, Is.EqualTo(expectedNums));
    }

    [Test]
    [TestCase(new int[0], false)]
    [TestCase(new int[] { 1 }, false)]
    [TestCase(new int[] { 1, 2, 3, 1 }, true)]
    [TestCase(new int[] { 1, 2, 3, 4 }, false)]
    [TestCase(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
    public void ContainsDuplicate_217(int[] nums, bool expectedResult)
    {
        var result = Solutions.Easy.Array.ContainsDuplicate_217(nums);

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase(new int[] { 0, 1, 0, 3, 12 }, new int[] { 1, 3, 12, 0, 0 })]
    [TestCase(new int[] { 1, 0, 0, 3, 4, 5 }, new int[] { 1, 3, 4, 5, 0, 0 })]
    [TestCase(new int[] { 1, 2, 3, 0, 0, 0 }, new int[] { 1, 2, 3, 0, 0, 0 })]
    [TestCase(new int[] { 0 }, new int[] { 0 })]
    public void MoveZeroes_283(int[] nums, int[] expectedNums)
    {
        Solutions.Easy.Array.MoveZeroes_283(nums);

        Assert.That(nums, Is.EqualTo(expectedNums));
    }

    [Test]
    [TestCase(new int[0], new int[] { 1 }, new int[0])]
    [TestCase(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 }, new int[] { 2, 2 })]
    [TestCase(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 }, new int[] { 4, 9 })]
    public void Intersect_350(int[] nums1, int[] nums2, int[] expectedResult)
    {
        var result = Solutions.Easy.Array.Intersect_350(nums1, nums2);

        Assert.That(result, Is.EquivalentTo(expectedResult));
    }
}
