#nullable disable
using Solutions.Common;
using Solutions.Trees;

namespace Solutions.Tests.Trees;

public class InvertBinaryTreeTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new InvertBinaryTree();
        Assert.Equal(new int?[] { 4, 7, 2, 9, 6, 3, 1 },
            TreeNode.ToLevelOrder(solver.Solve(TreeNode.FromLevelOrder(4, 2, 7, 1, 3, 6, 9))));
        Assert.Equal(new int?[] { 2, 3, 1 },
            TreeNode.ToLevelOrder(solver.Solve(TreeNode.FromLevelOrder(2, 1, 3))));
    }

    [Fact]
    public void Solve_EmptyTree()
    {
        Assert.Null(new InvertBinaryTree().Solve(null));
    }
}
