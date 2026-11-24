using Solutions.TwoPointers;

namespace Solutions.Tests.TwoPointers;

public class BestTimeToBuyAndSellStockTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new BestTimeToBuyAndSellStock();
        Assert.Equal(5, solver.Solve(new[] { 7, 1, 5, 3, 6, 4 }));
        Assert.Equal(0, solver.Solve(new[] { 7, 6, 4, 3, 1 }));
    }
}
