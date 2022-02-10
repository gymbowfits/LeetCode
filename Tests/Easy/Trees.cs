using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace LeetCode.Tests.Easy;

public class Trees
{
    [Test]
    [TestCase(new object[] { 2, 1, 3 }, true)]
    [TestCase(new object[] { 2, 2, 2 }, false)]
    [TestCase(new object[] { 5, 1, 4, null, null, 3, 6 }, false)]
    [TestCase(new object[] { 2147483647 }, true)]
    public void IsValidBst_98(object[] tree, bool expectedResult)
    {
        var root = (Solutions.Easy.Trees.TreeNode)tree;

        var result = Solutions.Easy.Trees.IsValidBst_98(root);

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase(new object[] { 3, 9, 20, null, null, 15, 7 }, 3)]
    [TestCase(new object[] { 1, null, 2 }, 2)]
    public void MaxDepth_104(object[] tree, int expectedResult)
    {
        var root = (Solutions.Easy.Trees.TreeNode)tree;

        var result = Solutions.Easy.Trees.MaxDepth_104(root);

        Assert.That(result, Is.EqualTo(expectedResult));
    }
}
