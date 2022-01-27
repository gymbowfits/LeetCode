using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace LeetCode.Tests.Easy;

public class LinkedLists
{
    [Test]
    [TestCase(new int[] { 1, 2, 3, 4, 5 })]
    public void ReverseLinkedList_206_1(int[] list)
    {
        var rootNode = (Solutions.Easy.LinkedLists.ListNode)list;

        var reversedRootNode = Solutions.Easy.LinkedLists.ReverseLinkedList_206(rootNode);

        Assert.That(reversedRootNode.val, Is.EqualTo(5));
        Assert.That(reversedRootNode.next.val, Is.EqualTo(4));
        Assert.That(reversedRootNode.next.next.val, Is.EqualTo(3));
        Assert.That(reversedRootNode.next.next.next.val, Is.EqualTo(2));
        Assert.That(reversedRootNode.next.next.next.next.val, Is.EqualTo(1));
        Assert.That(reversedRootNode.next.next.next.next.next, Is.Null);
    }

    [Test]
    [TestCase(new int[] { 4, 5, 1, 9 })]
    public void DeleteNode_237_1(int[] list)
    {
        var rootNode = (Solutions.Easy.LinkedLists.ListNode)list;

        Solutions.Easy.LinkedLists.DeleteNode_237(rootNode.next.next); // 1

        Assert.That(rootNode.val, Is.EqualTo(4));
        Assert.That(rootNode.next.val, Is.EqualTo(5));
        Assert.That(rootNode.next.next.val, Is.EqualTo(9));
        Assert.That(rootNode.next.next.next, Is.Null);
    }

    [Test]
    [TestCase(new int[] { 4, 5, 1, 9 })]
    public void DeleteNode_237_2(int[] list)
    {
        var rootNode = (Solutions.Easy.LinkedLists.ListNode)list;

        Solutions.Easy.LinkedLists.DeleteNode_237(rootNode.next); // 5

        Assert.That(rootNode.val, Is.EqualTo(4));
        Assert.That(rootNode.next.val, Is.EqualTo(1));
        Assert.That(rootNode.next.next.val, Is.EqualTo(9));
        Assert.That(rootNode.next.next.next, Is.Null);
    }
}
