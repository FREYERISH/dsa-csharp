using Solutions.Warmup;

namespace Solutions.Tests.Warmup;

public class KidsWithCandiesTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new KidsWithCandies();
        Assert.Equal(new[] { true, true, true, false, true }, solver.Solve(new[] { 2, 3, 5, 1, 3 }, 3).ToArray());
        Assert.Equal(new[] { true, false, false, false, false }, solver.Solve(new[] { 4, 2, 1, 1, 2 }, 1).ToArray());
        Assert.Equal(new[] { true, false, true }, solver.Solve(new[] { 12, 1, 12 }, 10).ToArray());
    }
}
