using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace LeetCode.Tests.Easy;

public class Trees
{
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
