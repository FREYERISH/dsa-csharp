using Solutions.RecursionBinarySearch;

namespace Solutions.Tests.RecursionBinarySearch;

public class SearchInRotatedSortedArrayTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new SearchInRotatedSortedArray();
        Assert.Equal(4, solver.Solve(new[] { 4, 5, 6, 7, 0, 1, 2 }, 0));
        Assert.Equal(-1, solver.Solve(new[] { 4, 5, 6, 7, 0, 1, 2 }, 3));
        Assert.Equal(-1, solver.Solve(new[] { 1 }, 0));
    }

    [Fact]
    public void Solve_TwoElements()
    {
        Assert.Equal(1, new SearchInRotatedSortedArray().Solve(new[] { 3, 1 }, 1));
    }
}
