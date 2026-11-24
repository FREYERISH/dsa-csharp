#nullable disable
using Solutions.Common;
using Solutions.LinkedLists;

namespace Solutions.Tests.LinkedLists;

public class MergeTwoSortedListsTests
{
    [Fact]
    public void Solve_LeetCodeExample1()
    {
        var result = new MergeTwoSortedLists().Solve(ListNode.FromArray(1, 2, 4), ListNode.FromArray(1, 3, 4));
        Assert.Equal(new[] { 1, 1, 2, 3, 4, 4 }, ListNode.ToArray(result));
    }

    [Fact]
    public void Solve_BothEmpty()
    {
        Assert.Null(new MergeTwoSortedLists().Solve(null, null));
    }

    [Fact]
    public void Solve_OneEmpty()
    {
        var result = new MergeTwoSortedLists().Solve(null, ListNode.FromArray(0));
        Assert.Equal(new[] { 0 }, ListNode.ToArray(result));
    }
}
