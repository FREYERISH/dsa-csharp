using Solutions.RecursionBinarySearch;

namespace Solutions.Tests.RecursionBinarySearch;

public class BinarySearchTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new BinarySearch();
        Assert.Equal(4, solver.Solve(new[] { -1, 0, 3, 5, 9, 12 }, 9));
        Assert.Equal(-1, solver.Solve(new[] { -1, 0, 3, 5, 9, 12 }, 2));
    }

    [Fact]
    public void Solve_EdgeCases()
    {
        var solver = new BinarySearch();
        Assert.Equal(0, solver.Solve(new[] { 5 }, 5));
        Assert.Equal(0, solver.Solve(new[] { -1, 0, 3 }, -1));
        Assert.Equal(2, solver.Solve(new[] { -1, 0, 3 }, 3));
    }
}
