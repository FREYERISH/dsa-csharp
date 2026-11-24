using Solutions.TwoPointers;

namespace Solutions.Tests.TwoPointers;

public class ContainerWithMostWaterTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new ContainerWithMostWater();
        Assert.Equal(49, solver.Solve(new[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 }));
        Assert.Equal(1, solver.Solve(new[] { 1, 1 }));
    }
}
