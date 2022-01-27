using System;

namespace LeetCode.Solutions.Easy;

public static class Trees
{
    public class TreeNode
    {
        public object val { get; set; }

        public TreeNode left { get; set; }

        public TreeNode right { get; set; }

        public TreeNode(object val = null, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }

        public static explicit operator TreeNode(object[] values)
        {
            return TreeNode_Recursive(values, 0, values.Length);
        }

        private static TreeNode TreeNode_Recursive(object[] values, int i, int length)
        {
            if ((i > length) || (values[i] == null))
            {
                return null;
            }

            return new TreeNode(
                           values[i],
                           TreeNode_Recursive(values, (i * 2) + 1, length),
                           TreeNode_Recursive(values, (i * 2) + 2, length));
        }
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
