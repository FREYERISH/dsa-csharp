using Solutions.Warmup;

namespace Solutions.Tests.Warmup;

public class RichestCustomerWealthTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new RichestCustomerWealth();
        Assert.Equal(6, solver.Solve(new[] { new[] { 1, 2, 3 }, new[] { 3, 2, 1 } }));
        Assert.Equal(10, solver.Solve(new[] { new[] { 1, 5 }, new[] { 7, 3 }, new[] { 3, 5 } }));
        Assert.Equal(17, solver.Solve(new[] { new[] { 2, 8, 7 }, new[] { 7, 1, 3 }, new[] { 1, 9, 5 } }));
    }
}
