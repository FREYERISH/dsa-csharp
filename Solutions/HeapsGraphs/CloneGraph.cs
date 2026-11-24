#nullable disable
using Solutions.Common;

namespace Solutions.HeapsGraphs;

// Clone Graph (Medium)
// https://leetcode.com/problems/clone-graph/
// On LeetCode, the method is called: CloneGraph  (copy everything inside Solve)
//
// Before coding, say out loud: your approach, then time and space complexity.
//
// Hints (read one at a time, only if you're stuck for 20+ minutes):
//   1. You must create NEW nodes. The test checks that no original node is reused.
//   2. Dictionary<Node, Node>: original -> its copy. This also stops you looping forever around cycles.
//   3. DFS: if the node is already in the dictionary, return its copy. Otherwise create the copy, store it, then clone each neighbour and add it to the copy's neighbors.
public class CloneGraph
{
    public Node Solve(Node node)
    {
        // TODO: write your solution here, then delete the line below.
        throw new NotImplementedException();
    }
}
