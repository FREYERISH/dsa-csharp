#nullable disable
using Solutions.Common;

namespace Solutions.LinkedLists;

// Remove Nth Node From End of List (Medium)
// https://leetcode.com/problems/remove-nth-node-from-end-of-list/
// On LeetCode, the method is called: RemoveNthFromEnd  (copy everything inside Solve)
//
// Before coding, say out loud: your approach, then time and space complexity.
//
// Hints (read one at a time, only if you're stuck for 20+ minutes):
//   1. Use a dummy node pointing to head; it handles removing the first node.
//   2. Start fast and slow at dummy. Move fast n + 1 steps ahead first.
//   3. Then move both until fast is null. Now slow.next is the node to remove: slow.next = slow.next.next.
//   4. Return dummy.next.
public class RemoveNthNodeFromEnd
{
    public ListNode Solve(ListNode head, int n)
    {
        // TODO: write your solution here, then delete the line below.
        throw new NotImplementedException();
    }
}
