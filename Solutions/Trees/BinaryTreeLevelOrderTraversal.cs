#nullable disable
using Solutions.Common;

namespace Solutions.Trees;

// Binary Tree Level Order Traversal (Medium)
// https://leetcode.com/problems/binary-tree-level-order-traversal/
// On LeetCode, the method is called: LevelOrder  (copy everything inside Solve)
//
// Before coding, say out loud: your approach, then time and space complexity.
//
// Hints (read one at a time, only if you're stuck for 20+ minutes):
//   1. BFS with a Queue<TreeNode>. Start by enqueuing root (if it isn't null).
//   2. While the queue isn't empty: int size = queue.Count. That's how many nodes are on this level.
//   3. Dequeue exactly 'size' nodes into one list, enqueuing their children as you go. Add the list to the result.
public class BinaryTreeLevelOrderTraversal
{
    public IList<IList<int>> Solve(TreeNode root)
    {
        // TODO: write your solution here, then delete the line below.
        throw new NotImplementedException();
    }
}
