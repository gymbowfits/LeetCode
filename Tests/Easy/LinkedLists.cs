using System;
using System.Collections.Generic;

using LeetCode.Solutions.Easy;

using NUnit.Framework;


namespace LeetCode.Tests.Easy;

public class LinkedLists
{
    [Test]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 1, 2, 3, 5 })]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3, new int[] { 1, 2, 4, 5 })]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5, new int[] { 2, 3, 4, 5 })]
    [TestCase(new int[] { 1 }, 1, new int[0])]
    [TestCase(new int[] { 1, 2 }, 1, new int[] { 1 })]
    public void RemoveNthFromEnd_19(int[] list, int n, int[] expectedResult)
    {
        var result = Solutions.Easy.LinkedLists.RemoveNthFromEnd_19((Solutions.Easy.LinkedLists.ListNode)list, n);

        Assert.That((int[])result, Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase(new int[] { 1, 2, 4 }, new int[] { 1, 3, 4 }, new int[] { 1, 1, 2, 3, 4, 4 })]
    [TestCase(new int[] { 2, 2, 4 }, new int[] { 1, 3, 4 }, new int[] { 1, 2, 2, 3, 4, 4 })]
    [TestCase(new int[] { 1, 2, 4 }, new int[] { 2, 3, 4 }, new int[] { 1, 2, 2, 3, 4, 4 })]
    [TestCase(new int[0], new int[0], new int[0])]
    [TestCase(new int[0], new int[] { 0 }, new int[] { 0 })]
    [TestCase(new int[] { 0 }, new int[0], new int[] { 0 })]
    public void MergeTwoLists_21(int[] list1, int[] list2, int[] expectedResult)
    {
        var result = Solutions.Easy.LinkedLists.MergeTwoLists_21((Solutions.Easy.LinkedLists.ListNode)list1, (Solutions.Easy.LinkedLists.ListNode)list2);

        Assert.That((int[])result, Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, -1, false)]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 1, true)]
    [TestCase(new int[] { 1, 2 }, 0, true)]
    [TestCase(new int[] { 1 }, -1, false)]
    public void HasCycle_141(int[] list, int cycle, bool expectedResult)
    {
        var linkedList = (Solutions.Easy.LinkedLists.ListNode)list;

        var currentNode = linkedList;
        Solutions.Easy.LinkedLists.ListNode cycleNode = currentNode;
        var i = 0;

        while (currentNode.next != null)
        {
            currentNode = currentNode.next;

            if (++i == cycle)
            {
                cycleNode = currentNode;
            }
        }

        if (cycle != -1)
        {
            currentNode.next = cycleNode;
        }

        var result = Solutions.Easy.LinkedLists.HasCycle(linkedList);

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
    public void ReverseLinkedList_206(int[] list, int[] expectedResult)
    {
        var head = (Solutions.Easy.LinkedLists.ListNode)list;

        var reversedHead = Solutions.Easy.LinkedLists.ReverseLinkedList_206(head);

        Assert.That((int[])reversedHead, Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 5, 4, 3, 2, 1 })]
    public void ReverseLinkedList_206_Cloned(int[] list, int[] expectedResult)
    {
        var head = (Solutions.Easy.LinkedLists.ListNode)list;

        var result = Solutions.Easy.LinkedLists.ReverseLinkedList_206_Cloned(head);

        Assert.That((int[])result, Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase(new int[] { 1 }, true)]
    [TestCase(new int[] { 1, 2, 2, 1 }, true)]
    [TestCase(new int[] { 1, 2, 3, 2, 1 }, true)]
    [TestCase(new int[] { 1, 2 }, false)]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, false)]
    public void IsPalindrome_234(int[] list, bool expectedResult)
    {
        var result = Solutions.Easy.LinkedLists.IsPalindrome_234((Solutions.Easy.LinkedLists.ListNode)list);

        Assert.That(result, Is.EqualTo(expectedResult));
    }

    [Test]
    [TestCase(new int[] { 4, 5, 1, 9 })]
    public void DeleteNode_237_1(int[] list)
    {
        var head = (Solutions.Easy.LinkedLists.ListNode)list;

        Solutions.Easy.LinkedLists.DeleteNode_237(head.next.next); // 1

        Assert.That(head.val, Is.EqualTo(4));
        Assert.That(head.next.val, Is.EqualTo(5));
        Assert.That(head.next.next.val, Is.EqualTo(9));
        Assert.That(head.next.next.next, Is.Null);
    }

    [Test]
    [TestCase(new int[] { 4, 5, 1, 9 })]
    public void DeleteNode_237_2(int[] list)
    {
        var head = (Solutions.Easy.LinkedLists.ListNode)list;

        Solutions.Easy.LinkedLists.DeleteNode_237(head.next); // 5

        Assert.That(head.val, Is.EqualTo(4));
        Assert.That(head.next.val, Is.EqualTo(1));
        Assert.That(head.next.next.val, Is.EqualTo(9));
        Assert.That(head.next.next.next, Is.Null);
    }

    [Test]
    [TestCase(new int[] { 1 }, 1, new int[] { 1 })]
    [TestCase(new int[] { 1, 2 }, 1, new int[] { 2, 1 })]
    [TestCase(new int[] { 1, 2 }, 2, new int[] { 2, 1 })]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 1, new int[] { 5, 2, 3, 4, 1 })]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 1, 4, 3, 2, 5 })]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, new int[] { 1, 4, 3, 2, 5 })]
    [TestCase(new int[] { 1, 2, 3, 4, 5 }, 5, new int[] { 5, 2, 3, 4, 1 })]
    [TestCase(new int[] { 7, 9, 6, 6, 7, 8, 3, 0, 9, 5 }, 5, new int[] { 7, 9, 6, 6, 8, 7, 3, 0, 9, 5 })]
    public void SwapNodes_1721(int[] list, int k, int[] expectedResult)
    {
        var result = Solutions.Easy.LinkedLists.SwapNodes_1721((Solutions.Easy.LinkedLists.ListNode)list, k);

        Assert.That((int[])result, Is.EqualTo(expectedResult));
    }
}
