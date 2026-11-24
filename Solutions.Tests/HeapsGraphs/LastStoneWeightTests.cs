using Solutions.HeapsGraphs;

namespace Solutions.Tests.HeapsGraphs;

public class LastStoneWeightTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new LastStoneWeight();
        Assert.Equal(1, solver.Solve(new[] { 2, 7, 4, 1, 8, 1 }));
        Assert.Equal(1, solver.Solve(new[] { 1 }));
    }

    [Fact]
    public void Solve_AllStonesDestroyed()
    {
        Assert.Equal(0, new LastStoneWeight().Solve(new[] { 2, 2 }));
    }
}
