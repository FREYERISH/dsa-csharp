using Solutions.Warmup;

namespace Solutions.Tests.Warmup;

public class RunningSumTests
{
    [Fact]
    public void Solve_ReturnsRunningTotals()
    {
        var solver = new RunningSum();

        int[] result = solver.Solve(new[] { 1, 2, 3, 4 });

        Assert.Equal(new[] { 1, 3, 6, 10 }, result);
    }
}