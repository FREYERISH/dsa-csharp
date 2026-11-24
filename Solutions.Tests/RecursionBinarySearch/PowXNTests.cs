using Solutions.RecursionBinarySearch;

namespace Solutions.Tests.RecursionBinarySearch;

public class PowXNTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new PowXN();
        Assert.Equal(1024.0, solver.Solve(2.0, 10), 5);
        Assert.Equal(9.261, solver.Solve(2.1, 3), 5);
        Assert.Equal(0.25, solver.Solve(2.0, -2), 5);
    }

    [Fact]
    public void Solve_ZeroPower()
    {
        Assert.Equal(1.0, new PowXN().Solve(5.0, 0), 5);
    }

    [Fact]
    public void Solve_MinIntPower_DoesNotOverflow()
    {
        Assert.Equal(1.0, new PowXN().Solve(1.0, int.MinValue), 5);
        Assert.Equal(0.0, new PowXN().Solve(2.0, int.MinValue), 5);
    }
}
