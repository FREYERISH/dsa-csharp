using Solutions.Warmup;

namespace Solutions.Tests.Warmup;

public class ConcatenationOfArrayTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new ConcatenationOfArray();
        Assert.Equal(new[] { 1, 2, 1, 1, 2, 1 }, solver.Solve(new[] { 1, 2, 1 }));
        Assert.Equal(new[] { 1, 3, 2, 1, 1, 3, 2, 1 }, solver.Solve(new[] { 1, 3, 2, 1 }));
    }
}
