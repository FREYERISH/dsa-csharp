using Solutions.RecursionBinarySearch;

namespace Solutions.Tests.RecursionBinarySearch;

public class FibonacciNumberTests
{
    [Fact]
    public void Solve_SmallValues()
    {
        var solver = new FibonacciNumber();
        Assert.Equal(0, solver.Solve(0));
        Assert.Equal(1, solver.Solve(1));
        Assert.Equal(1, solver.Solve(2));
        Assert.Equal(2, solver.Solve(3));
        Assert.Equal(3, solver.Solve(4));
    }

    [Fact]
    public void Solve_Thirty()
    {
        Assert.Equal(832040, new FibonacciNumber().Solve(30));
    }
}
