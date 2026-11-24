#nullable disable
using Solutions.Common;
using Solutions.Trees;

namespace Solutions.Tests.Trees;

public class SameTreeTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new SameTree();
        Assert.True(solver.Solve(TreeNode.FromLevelOrder(1, 2, 3), TreeNode.FromLevelOrder(1, 2, 3)));
        Assert.False(solver.Solve(TreeNode.FromLevelOrder(1, 2), TreeNode.FromLevelOrder(1, null, 2)));
        Assert.False(solver.Solve(TreeNode.FromLevelOrder(1, 2, 1), TreeNode.FromLevelOrder(1, 1, 2)));
    }

    [Fact]
    public void Solve_BothEmpty()
    {
        Assert.True(new SameTree().Solve(null, null));
    }
}
