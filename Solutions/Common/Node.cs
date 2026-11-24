#nullable disable
namespace Solutions.Common;

// Same shape as LeetCode's Node for "Clone Graph", so your code pastes straight into LeetCode.
public class Node
{
    public int val;
    public IList<Node> neighbors;

    public Node()
    {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val)
    {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors)
    {
        val = _val;
        neighbors = _neighbors;
    }

    // ---- Helpers for the tests (not part of LeetCode) ----

    // LeetCode's format: adjacency[i] lists the neighbours of node (i + 1). Returns node 1, or null if empty.
    public static Node FromAdjacency(int[][] adjacency)
    {
        if (adjacency.Length == 0) return null;
        var nodes = new Node[adjacency.Length];
        for (int i = 0; i < nodes.Length; i++) nodes[i] = new Node(i + 1);
        for (int i = 0; i < adjacency.Length; i++)
            foreach (int neighbour in adjacency[i])
                nodes[i].neighbors.Add(nodes[neighbour - 1]);
        return nodes[0];
    }

    // Every node reachable from start (compared by reference).
    public static HashSet<Node> CollectNodes(Node start)
    {
        var seen = new HashSet<Node>(ReferenceEqualityComparer.Instance);
        if (start == null) return seen;
        var stack = new Stack<Node>();
        stack.Push(start);
        while (stack.Count > 0)
        {
            Node node = stack.Pop();
            if (!seen.Add(node)) continue;
            foreach (Node next in node.neighbors) stack.Push(next);
        }
        return seen;
    }

    // Back to LeetCode's format, e.g. "1:2,4|2:1,3|3:2,4|4:1,3".
    public static string Describe(Node start)
    {
        var parts = CollectNodes(start)
            .OrderBy(n => n.val)
            .Select(n => n.val + ":" + string.Join(",", n.neighbors.Select(x => x.val)));
        return string.Join("|", parts);
    }
}
