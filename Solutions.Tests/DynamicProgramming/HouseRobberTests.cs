using Solutions.DynamicProgramming;

namespace Solutions.Tests.DynamicProgramming;

public class HouseRobberTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new HouseRobber();
        Assert.Equal(4, solver.Solve(new[] { 1, 2, 3, 1 }));
        Assert.Equal(12, solver.Solve(new[] { 2, 7, 9, 3, 1 }));
    }

    [Fact]
    public void Solve_SkipTwoInARow()
    {
        Assert.Equal(4, new HouseRobber().Solve(new[] { 2, 1, 1, 2 }));
    }
}
