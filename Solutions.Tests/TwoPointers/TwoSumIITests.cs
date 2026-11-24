using Solutions.TwoPointers;

namespace Solutions.Tests.TwoPointers;

public class TwoSumIITests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new TwoSumII();
        Assert.Equal(new[] { 1, 2 }, solver.Solve(new[] { 2, 7, 11, 15 }, 9));
        Assert.Equal(new[] { 1, 3 }, solver.Solve(new[] { 2, 3, 4 }, 6));
        Assert.Equal(new[] { 1, 2 }, solver.Solve(new[] { -1, 0 }, -1));
    }
}
