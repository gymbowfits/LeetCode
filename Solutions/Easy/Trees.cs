using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Solutions.Easy;

public static class Trees
{
    public class TreeNode
    {
        public IComparable val { get; set; }

        public TreeNode left { get; set; }

        public TreeNode right { get; set; }

        public TreeNode(IComparable val = null, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public static explicit operator TreeNode(object[] values)
        {
            return TreeNode_Recursive(values.Select(v => (IComparable)v).ToList(), 0, values.Length);
        }

        private static TreeNode TreeNode_Recursive(IList<IComparable> values, int i, int length)
        {
            if ((i >= length) || (values[i] == null))
            {
                return null;
            }

            return new TreeNode(
                           values[i],
                           TreeNode_Recursive(values, (i * 2) + 1, length),
                           TreeNode_Recursive(values, (i * 2) + 2, length));
        }
    }

    // 98. Validate Binary Search Tree
    public static bool IsValidBst_98(TreeNode root)
    {
        return IsValidBst_98_Recursive(root, null, null);
    }

    private static bool IsValidBst_98_Recursive(TreeNode root, object minValue, object maxValue)
    {
        if ((root == null) ||
            ((minValue == null || root.val.CompareTo(minValue) > 0) &&
             (maxValue == null || root.val.CompareTo(maxValue) < 0) &&
             IsValidBst_98_Recursive(root.left, minValue, root.val) &&
             IsValidBst_98_Recursive(root.right, root.val, maxValue)))
        {
            return true;
        }

        return false;
    }

    // 104. Maximum Depth of Binary Tree
    public static int MaxDepth_104(TreeNode root)
    {
        return MaxDepth_104_Recursive(root, 0);
    }

    private static int MaxDepth_104_Recursive(TreeNode node, int depth)
    {
        if (node == null)
        {
            return depth;
        }

        var leftDepth = MaxDepth_104_Recursive(node.left, depth + 1);
        var rightDepth = MaxDepth_104_Recursive(node.right, depth + 1);

        return Math.Max(leftDepth, rightDepth);
    }
}
