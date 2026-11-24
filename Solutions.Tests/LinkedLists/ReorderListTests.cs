#nullable disable
using Solutions.Common;
using Solutions.LinkedLists;

namespace Solutions.Tests.LinkedLists;

public class ReorderListTests
{
    [Fact]
    public void Solve_EvenLength()
    {
        ListNode head = ListNode.FromArray(1, 2, 3, 4);
        new ReorderList().Solve(head);
        Assert.Equal(new[] { 1, 4, 2, 3 }, ListNode.ToArray(head));
    }

    [Fact]
    public void Solve_OddLength()
    {
        ListNode head = ListNode.FromArray(1, 2, 3, 4, 5);
        new ReorderList().Solve(head);
        Assert.Equal(new[] { 1, 5, 2, 4, 3 }, ListNode.ToArray(head));
    }

    [Fact]
    public void Solve_SingleNode()
    {
        ListNode head = ListNode.FromArray(1);
        new ReorderList().Solve(head);
        Assert.Equal(new[] { 1 }, ListNode.ToArray(head));
    }
}
