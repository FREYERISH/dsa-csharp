#nullable disable
using Solutions.Common;
using Solutions.HeapsGraphs;

namespace Solutions.Tests.HeapsGraphs;

public class CloneGraphTests
{
    [Fact]
    public void Solve_FourNodeCycle()
    {
        Node original = Node.FromAdjacency(new[] { new[] { 2, 4 }, new[] { 1, 3 }, new[] { 2, 4 }, new[] { 1, 3 } });
        Node clone = new CloneGraph().Solve(original);

        Assert.Equal(Node.Describe(original), Node.Describe(clone));

        var originalNodes = Node.CollectNodes(original).ToList();
        foreach (Node copied in Node.CollectNodes(clone))
            Assert.DoesNotContain(copied, originalNodes);
    }

    [Fact]
    public void Solve_SingleNode()
    {
        Node original = Node.FromAdjacency(new[] { new int[0] });
        Node clone = new CloneGraph().Solve(original);
        Assert.NotSame(original, clone);
        Assert.Equal(1, clone.val);
        Assert.Empty(clone.neighbors);
    }

    [Fact]
    public void Solve_EmptyGraph()
    {
        Assert.Null(new CloneGraph().Solve(null));
    }
}
