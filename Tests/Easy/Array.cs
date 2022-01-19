using NUnit.Framework;

namespace LeetCode.Tests.Easy;

public class Array
{
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
    [TestCase(new int[0], new int[] { 1 }, new int[0])]
    [TestCase(new int[] { 1, 2, 2, 1 }, new int[] { 2, 2 }, new int[] { 2, 2 })]
    [TestCase(new int[] { 4, 9, 5 }, new int[] { 9, 4, 9, 8, 4 }, new int[] { 4, 9 })]
    public void Intersect_350(int[] nums1, int[] nums2, int[] expectedResult)
    {
        var result = Solutions.Easy.Array.Intersect_350(nums1, nums2);

        Assert.That(result, Is.EquivalentTo(expectedResult));
    }
}
