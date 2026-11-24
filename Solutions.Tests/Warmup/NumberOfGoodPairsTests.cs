using Solutions.Warmup;

namespace Solutions.Tests.Warmup;

public class NumberOfGoodPairsTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new NumberOfGoodPairs();
        Assert.Equal(4, solver.Solve(new[] { 1, 2, 3, 1, 1, 3 }));
        Assert.Equal(6, solver.Solve(new[] { 1, 1, 1, 1 }));
        Assert.Equal(0, solver.Solve(new[] { 1, 2, 3 }));
    }
}
