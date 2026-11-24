#nullable disable
using Solutions.Common;
using Solutions.Trees;

namespace Solutions.Tests.Trees;

public class LowestCommonAncestorOfBSTTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        TreeNode root = TreeNode.FromLevelOrder(6, 2, 8, 0, 4, 7, 9, null, null, 3, 5);
        var solver = new LowestCommonAncestorOfBST();
        Assert.Equal(6, solver.Solve(root, TreeNode.Find(root, 2), TreeNode.Find(root, 8)).val);
        Assert.Equal(2, solver.Solve(root, TreeNode.Find(root, 2), TreeNode.Find(root, 4)).val);
    }

    [Fact]
    public void Solve_NodeIsItsOwnAncestor()
    {
        TreeNode root = TreeNode.FromLevelOrder(2, 1);
        Assert.Equal(2, new LowestCommonAncestorOfBST().Solve(root, TreeNode.Find(root, 2), TreeNode.Find(root, 1)).val);
    }
}
