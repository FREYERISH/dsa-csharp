using Solutions.DynamicProgramming;

namespace Solutions.Tests.DynamicProgramming;

public class UniquePathsTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new UniquePaths();
        Assert.Equal(28, solver.Solve(3, 7));
        Assert.Equal(3, solver.Solve(3, 2));
    }

    [Fact]
    public void Solve_SingleCell()
    {
        Assert.Equal(1, new UniquePaths().Solve(1, 1));
    }
}
