#nullable disable
using Solutions.Common;
using Solutions.LinkedLists;

namespace Solutions.Tests.LinkedLists;

public class ReverseLinkedListTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new ReverseLinkedList();
        Assert.Equal(new[] { 5, 4, 3, 2, 1 }, ListNode.ToArray(solver.Solve(ListNode.FromArray(1, 2, 3, 4, 5))));
        Assert.Equal(new[] { 2, 1 }, ListNode.ToArray(solver.Solve(ListNode.FromArray(1, 2))));
    }

    [Fact]
    public void Solve_EmptyList()
    {
        Assert.Null(new ReverseLinkedList().Solve(null));
    }
}
