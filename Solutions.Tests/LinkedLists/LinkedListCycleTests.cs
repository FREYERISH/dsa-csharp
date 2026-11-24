#nullable disable
using Solutions.Common;
using Solutions.LinkedLists;

namespace Solutions.Tests.LinkedLists;

public class LinkedListCycleTests
{
    [Fact]
    public void Solve_WithCycle()
    {
        var solver = new LinkedListCycle();
        Assert.True(solver.Solve(ListNode.FromArrayWithCycle(new[] { 3, 2, 0, -4 }, 1)));
        Assert.True(solver.Solve(ListNode.FromArrayWithCycle(new[] { 1, 2 }, 0)));
    }

    [Fact]
    public void Solve_WithoutCycle()
    {
        var solver = new LinkedListCycle();
        Assert.False(solver.Solve(ListNode.FromArrayWithCycle(new[] { 1 }, -1)));
        Assert.False(solver.Solve(null));
    }
}
