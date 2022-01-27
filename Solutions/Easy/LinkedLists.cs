using System;

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

    // 237. Delete Node in a Linked List
    public static void DeleteNode_237(ListNode node)
    {
        node.val = node.next.val;
        node.next = node.next.next;
    }
}
