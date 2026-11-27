using Solutions.Warmup;

namespace Solutions.Tests.Warmup;

public class MaxConsecutiveOnesTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new MaxConsecutiveOnes();
        Assert.Equal(3, solver.Solve(new[] { 1, 1, 0, 1, 1, 1 }));
        Assert.Equal(2, solver.Solve(new[] { 1, 0, 1, 1, 0, 1 }));
    }

    [Fact]
    public void Solve_AllZeros()
    {
        Assert.Equal(0, new MaxConsecutiveOnes().Solve(new[] { 0, 0, 0 }));
    }
}
