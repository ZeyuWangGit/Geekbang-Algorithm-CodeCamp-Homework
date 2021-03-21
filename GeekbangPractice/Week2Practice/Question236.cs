using System;
using Xunit;

namespace Week2Practice
{
    // 236. 二叉树的最近公共祖先
    public class Question236
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null || root == p || root == q) return root;
            var left = LowestCommonAncestor(root.left, p, q);
            var right = LowestCommonAncestor(root.right, p, q);
            if (left == null && right == null) return null;
            if (left == null) return right;
            if (right == null) return left;
            return root;
        }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }


}
