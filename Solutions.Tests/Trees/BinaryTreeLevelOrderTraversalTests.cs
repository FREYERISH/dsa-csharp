#nullable disable
using Solutions.Common;
using Solutions.Trees;

namespace Solutions.Tests.Trees;

public class BinaryTreeLevelOrderTraversalTests
{
    private static string Describe(IList<IList<int>> levels) =>
        string.Join("|", levels.Select(level => string.Join(",", level)));

    [Fact]
    public void Solve_LeetCodeExample1()
    {
        var result = new BinaryTreeLevelOrderTraversal().Solve(TreeNode.FromLevelOrder(3, 9, 20, null, null, 15, 7));
        Assert.Equal("3|9,20|15,7", Describe(result));
    }

    [Fact]
    public void Solve_SingleNode()
    {
        Assert.Equal("1", Describe(new BinaryTreeLevelOrderTraversal().Solve(TreeNode.FromLevelOrder(1))));
    }

    [Fact]
    public void Solve_EmptyTree()
    {
        Assert.Empty(new BinaryTreeLevelOrderTraversal().Solve(null));
    }
}
