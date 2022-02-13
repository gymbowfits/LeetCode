using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace LeetCode.Tests.Easy;

public class SortingSearching
{
    [Test]
    [TestCase(1, 1)]
    [TestCase(100, 14)]
    [TestCase(int.MaxValue, 14)]
    public void FirstBadVersion_278(int n, int badVersion)
    {
        var result = Solutions.Easy.SortingSearching.FirstBadVersion_278(n, badVersion);

        Assert.That(result, Is.EqualTo(badVersion));
    }
}
