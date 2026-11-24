using Solutions.RecursionBinarySearch;

namespace Solutions.Tests.RecursionBinarySearch;

public class ClimbingStairsTests
{
    [Fact]
    public void Solve_SmallValues()
    {
        var solver = new ClimbingStairs();
        Assert.Equal(1, solver.Solve(1));
        Assert.Equal(2, solver.Solve(2));
        Assert.Equal(3, solver.Solve(3));
        Assert.Equal(8, solver.Solve(5));
    }

    [Fact]
    public void Solve_FortyFive_NeedsMemoization()
    {
        Assert.Equal(1836311903, new ClimbingStairs().Solve(45));
    }
}
