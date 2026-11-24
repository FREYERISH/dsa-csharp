#nullable disable
using Solutions.Common;
using Solutions.Trees;

namespace Solutions.Tests.Trees;

public class MaximumDepthOfBinaryTreeTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new MaximumDepthOfBinaryTree();
        Assert.Equal(3, solver.Solve(TreeNode.FromLevelOrder(3, 9, 20, null, null, 15, 7)));
        Assert.Equal(2, solver.Solve(TreeNode.FromLevelOrder(1, null, 2)));
    }

    [Fact]
    public void Solve_EmptyTree()
    {
        Assert.Equal(0, new MaximumDepthOfBinaryTree().Solve(null));
    }
}
