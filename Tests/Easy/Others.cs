using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace LeetCode.Tests.Easy;

public class Others
{
    [Test]
    [TestCase("A", 1)]
    [TestCase("AB", 28)]
    [TestCase("ZY", 701)]
    public void TitleToNumber_171(string columnTitle, int expectedResult)
    {
        var result = Solutions.Easy.Others.TitleToNumber_171(columnTitle);

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase(43261596u, 964176192u)]
    [TestCase(4294967293u, 3221225471u)]
    public void ReverseBits_190(uint n, uint expectedResult)
    {
        var result = Solutions.Easy.Others.ReverseBits_190(n);

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase(11u, 3)]
    [TestCase(128u, 1)]
    [TestCase(4294967293u, 31)]
    public void HammingWeight_191(uint n, int expectedResult)
    {
        var result = Solutions.Easy.Others.HammingWeight_191(n);

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase(1, 4, 2)]
    [TestCase(3, 1, 1)]
    public void HammingDistance_461(int x, int y, int expectedResult)
    {
        var result = Solutions.Easy.Others.HammingDistance_461(x, y);

        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
