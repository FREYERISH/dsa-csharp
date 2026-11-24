#nullable disable
using Solutions.Common;
using Solutions.Trees;

namespace Solutions.Tests.Trees;

public class ValidateBinarySearchTreeTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new ValidateBinarySearchTree();
        Assert.True(solver.Solve(TreeNode.FromLevelOrder(2, 1, 3)));
        Assert.False(solver.Solve(TreeNode.FromLevelOrder(5, 1, 4, null, null, 3, 6)));
    }

    [Fact]
    public void Solve_GrandchildBreaksTheRule()
    {
        // 3 is in 6's left subtree, but it's also in 5's RIGHT subtree, so it must be > 5.
        Assert.False(new ValidateBinarySearchTree().Solve(TreeNode.FromLevelOrder(5, 4, 6, null, null, 3, 7)));
    }

    [Fact]
    public void Solve_IntMaxValue()
    {
        Assert.True(new ValidateBinarySearchTree().Solve(TreeNode.FromLevelOrder(2147483647)));
    }
}
