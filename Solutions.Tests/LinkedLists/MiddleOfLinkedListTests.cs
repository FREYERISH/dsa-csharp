#nullable disable
using Solutions.Common;
using Solutions.LinkedLists;

namespace Solutions.Tests.LinkedLists;

public class MiddleOfLinkedListTests
{
    [Fact]
    public void Solve_OddLength()
    {
        var result = new MiddleOfLinkedList().Solve(ListNode.FromArray(1, 2, 3, 4, 5));
        Assert.Equal(new[] { 3, 4, 5 }, ListNode.ToArray(result));
    }

    [Fact]
    public void Solve_EvenLength_ReturnsSecondMiddle()
    {
        var result = new MiddleOfLinkedList().Solve(ListNode.FromArray(1, 2, 3, 4, 5, 6));
        Assert.Equal(new[] { 4, 5, 6 }, ListNode.ToArray(result));
    }
}
