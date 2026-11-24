using Solutions.RecursionBinarySearch;

namespace Solutions.Tests.RecursionBinarySearch;

public class SearchInsertPositionTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new SearchInsertPosition();
        Assert.Equal(2, solver.Solve(new[] { 1, 3, 5, 6 }, 5));
        Assert.Equal(1, solver.Solve(new[] { 1, 3, 5, 6 }, 2));
        Assert.Equal(4, solver.Solve(new[] { 1, 3, 5, 6 }, 7));
        Assert.Equal(0, solver.Solve(new[] { 1, 3, 5, 6 }, 0));
    }
}
