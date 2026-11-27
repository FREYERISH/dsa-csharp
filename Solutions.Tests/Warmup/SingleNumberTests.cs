using Solutions.Warmup;

namespace Solutions.Tests.Warmup;

public class SingleNumberTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new SingleNumber();
        Assert.Equal(1, solver.Solve(new[] { 2, 2, 1 }));
        Assert.Equal(4, solver.Solve(new[] { 4, 1, 2, 1, 2 }));
        Assert.Equal(1, solver.Solve(new[] { 1 }));
    }
}
