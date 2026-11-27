using Solutions.Warmup;

namespace Solutions.Tests.Warmup;

public class ShuffleTheArrayTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new ShuffleTheArray();
        Assert.Equal(new[] { 2, 3, 5, 4, 1, 7 }, solver.Solve(new[] { 2, 5, 1, 3, 4, 7 }, 3));
        Assert.Equal(new[] { 1, 4, 2, 3, 3, 2, 4, 1 }, solver.Solve(new[] { 1, 2, 3, 4, 4, 3, 2, 1 }, 4));
        Assert.Equal(new[] { 1, 2, 1, 2 }, solver.Solve(new[] { 1, 1, 2, 2 }, 2));
    }
}
