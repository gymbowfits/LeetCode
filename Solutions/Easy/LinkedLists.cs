using System;
using System.Collections.Generic;

namespace LeetCode.Solutions.Easy;

public static class LinkedLists
{
    public class ListNode
    {
        public int val { get; set; }

        public ListNode next { get; set; }

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public static explicit operator ListNode(int[] values)
        {
            ListNode root = null;

            for (var i = values.Length - 1; i >= 0; i--)
            {
                root = new ListNode(values[i], root);
            }

            return root;
        }

        public static explicit operator int[](ListNode head)
        {
            var list = new List<int>();
            var current = head;

            while (current != null)
            {
                list.Add(current.val);
                current = current.next;
            }

            return list.ToArray();
        }
    }

    // 19. Remove Nth Node From End of List
    public static ListNode RemoveNthFromEnd_19(ListNode head, int n)
    {
        ListNode
            previous = null,
            delete = head,
            current = head;

        var i = 1;

        while (current.next != null)
        {
            current = current.next;

            if (i++ >= n)
            {
                previous = delete;
                delete = delete.next;
            }
        }

        if (head == delete)
        {
            return head.next;
        }
        else
        {
            previous.next = delete.next;
            return head;
        }
    }

    // 141. Linked List Cycle
    public static bool HasCycle(ListNode head)
    {
        ListNode
            slow = head,
            fast = head;

        while (fast?.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;

            if (slow == fast)
            {
                return true;
            }
        }

        return false;
    }

    // 206. Reverse Linked List
    public static ListNode ReverseLinkedList_206(ListNode head)
    {
        ListNode previousNode = null;

        while (head != null)
        {
            var nextNode = head.next;
            head.next = previousNode;
            previousNode = head;
            head = nextNode;
        }

        return previousNode;
    }

    // 234. Palindrome Linked List
    public static bool IsPalindrome_234(ListNode head)
    {
        if (head.next == null)
        {
            return true;
        }

        var nodeSlow = head;
        var nodeFast = head;

        while (nodeFast?.next != null)
        {
            nodeSlow = nodeSlow.next;
            nodeFast = nodeFast.next.next;
        }

        if (nodeFast != null) // odd
        {
            nodeSlow = nodeSlow.next;
        }

        var secondHalf = ReverseLinkedList_206(nodeSlow);

        nodeSlow = secondHalf;
        nodeFast = head;

        var result = true;

        while (nodeSlow != null)
        {
            if (nodeSlow.val != nodeFast.val)
            {
                result = false;
                break;
            }

            nodeSlow = nodeSlow.next;
            nodeFast = nodeFast.next;
        }

        ReverseLinkedList_206(secondHalf);

        return result;
    }

    // 237. Delete Node in a Linked List
    public static void DeleteNode_237(ListNode node)
    {
        node.val = node.next.val;
        node.next = node.next.next;
    }
}
