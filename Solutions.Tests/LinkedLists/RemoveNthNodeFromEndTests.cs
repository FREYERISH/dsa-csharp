#nullable disable
using Solutions.Common;
using Solutions.LinkedLists;

namespace Solutions.Tests.LinkedLists;

public class RemoveNthNodeFromEndTests
{
    [Fact]
    public void Solve_LeetCodeExample1()
    {
        var result = new RemoveNthNodeFromEnd().Solve(ListNode.FromArray(1, 2, 3, 4, 5), 2);
        Assert.Equal(new[] { 1, 2, 3, 5 }, ListNode.ToArray(result));
    }

    [Fact]
    public void Solve_RemoveOnlyNode()
    {
        Assert.Null(new RemoveNthNodeFromEnd().Solve(ListNode.FromArray(1), 1));
    }

    [Fact]
    public void Solve_RemoveLastNode()
    {
        var result = new RemoveNthNodeFromEnd().Solve(ListNode.FromArray(1, 2), 1);
        Assert.Equal(new[] { 1 }, ListNode.ToArray(result));
    }

    [Fact]
    public void Solve_RemoveFirstNode()
    {
        var result = new RemoveNthNodeFromEnd().Solve(ListNode.FromArray(1, 2), 2);
        Assert.Equal(new[] { 2 }, ListNode.ToArray(result));
    }
}
