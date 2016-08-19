﻿using System;
using Learning.DataStructures;

namespace Learning.InterviewQuestions.Trees
{
    // http://www.geeksforgeeks.org/how-to-determine-if-a-binary-tree-is-balanced/
    public class HeightBalancedBinaryTree : BinaryTree
    {
        /* Returns true if binary tree with root as root is height-balanced */
        //public bool IsBalanced(Node node)
        //{
        //    int lh; /* for height of left subtree */

        //    int rh; /* for height of right subtree */

        //    /* If tree is empty then return true */
        //    if (node == null)
        //        return true;

        //    /* Get the height of left and right sub trees */
        //    lh = height(node.left);
        //    rh = height(node.right);

        //    if (Math.abs(lh - rh) <= 1
        //            && IsBalanced(node.left)
        //            && IsBalanced(node.right))
        //        return true;

        //    /* If we reach here then tree is not height-balanced */
        //    return false;
        //}

        ///* UTILITY FUNCTIONS TO TEST isBalanced() FUNCTION */

        ///* returns maximum of two integers */
        //int max(int a, int b)
        //{
        //    return (a >= b) ? a : b;
        //}

        ///*  The function Compute the "height" of a tree. Height is the
        //    number of nodes along the longest path from the root node
        //    down to the farthest leaf node.*/
        //int height(Node node)
        //{
        //    /* base case tree is empty */
        //    if (node == null)
        //        return 0;

        //    /* If tree is not empty then height = 1 + max of left
        //     height and right heights */
        //    return 1 + max(height(node.left), height(node.right));
        //}

    }
}
