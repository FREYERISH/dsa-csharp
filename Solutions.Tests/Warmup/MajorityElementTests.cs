using Solutions.Warmup;

namespace Solutions.Tests.Warmup;

public class MajorityElementTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new MajorityElement();
        Assert.Equal(3, solver.Solve(new[] { 3, 2, 3 }));
        Assert.Equal(2, solver.Solve(new[] { 2, 2, 1, 1, 1, 2, 2 }));
    }

    [Fact]
    public void Solve_SingleElement()
    {
        Assert.Equal(7, new MajorityElement().Solve(new[] { 7 }));
    }
}
