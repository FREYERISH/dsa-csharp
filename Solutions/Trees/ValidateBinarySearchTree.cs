#nullable disable
using Solutions.Common;

namespace Solutions.Trees;

// Validate Binary Search Tree (Medium)
// https://leetcode.com/problems/validate-binary-search-tree/
// On LeetCode, the method is called: IsValidBST  (copy everything inside Solve)
//
// Before coding, say out loud: your approach, then time and space complexity.
//
// Hints (read one at a time, only if you're stuck for 20+ minutes):
//   1. Trap: checking only node.left.val < node.val < node.right.val is NOT enough. See the third test.
//   2. Every node must fit inside a range (min, max) passed down from its ancestors.
//   3. Going left, the max becomes the node's value. Going right, the min becomes the node's value.
//   4. Use long (or long?) for the bounds: a node can hold int.MaxValue.
public class ValidateBinarySearchTree
{
    public bool Solve(TreeNode root)
    {
        // TODO: write your solution here, then delete the line below.
        throw new NotImplementedException();
    }
}
