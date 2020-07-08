using System;
using System.Collections.Generic;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {


        }
    }

    class Solutions
    {
        // Problem: Given a binary tree, find its maximum depth.
        // The maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            if (root.left == null && root.right == null)
                return 1;

            return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
        }

        // Problem: Validate Binary Search Tree
        // Given a binary tree, determine if it is a valid binary search tree (BST).
        public bool IsValidBST(TreeNode root)
        {
            // Option - 1
            // return IsValidBST(root, Int64.MinValue, Int64.MaxValue);
            // Option - 2
            return IsValidBST(root, null, null);
        }

        private bool IsValidBST(TreeNode node, long min, long max)
        {
            if (node == null)
                return true;
            System.Console.WriteLine($"Node value is {node.val}, Min is {min}, Max is {max}");
            if (node.val < min || node.val > max)
                return false;

            return IsValidBST(node.left, min, (long)node.val - 1)
                    && IsValidBST(node.right, node.val + 1, max);
        }

        private bool IsValidBST(TreeNode node, int? min, int? max)
        {
            if (node == null)
                return true;

            if (min != null && node.val <= min)
                return false;

            if (max != null && node.val >= max)
                return false;

            return IsValidBST(node.left, min, node.val)
                    && IsValidBST(node.right, node.val, max);
        }

        // Problem - Binary Tree Level Order Traversal
        // Given a binary tree, return the level order traversal of its nodes' values. (ie, from left to right, level by level).
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var result = new List<IList<int>>();

            if (root == null)
                return result;

            LevelOrder(root, 0, result);

            return result;
        }

        private void LevelOrder(TreeNode root, int height, IList<IList<int>> levelResult)
        {
            if (root == null)
                return;

            if (height >= levelResult.Count)
                levelResult.Add(new List<int>());

            levelResult[height].Add(root.val);
            LevelOrder(root.left, height + 1, levelResult);
            LevelOrder(root.right, height + 1, levelResult);
        }
    }

    // Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
