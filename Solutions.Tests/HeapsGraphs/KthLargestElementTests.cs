using Solutions.HeapsGraphs;

namespace Solutions.Tests.HeapsGraphs;

public class KthLargestElementTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new KthLargestElement();
        Assert.Equal(5, solver.Solve(new[] { 3, 2, 1, 5, 6, 4 }, 2));
        Assert.Equal(4, solver.Solve(new[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4));
    }
}
