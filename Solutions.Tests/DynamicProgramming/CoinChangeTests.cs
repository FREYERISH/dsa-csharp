using Solutions.DynamicProgramming;

namespace Solutions.Tests.DynamicProgramming;

public class CoinChangeTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new CoinChange();
        Assert.Equal(3, solver.Solve(new[] { 1, 2, 5 }, 11));
        Assert.Equal(-1, solver.Solve(new[] { 2 }, 3));
        Assert.Equal(0, solver.Solve(new[] { 1 }, 0));
    }

    [Fact]
    public void Solve_GreedyWouldFail()
    {
        // Greedy takes 4 + 1 + 1 (3 coins). The best is 3 + 3 (2 coins).
        Assert.Equal(2, new CoinChange().Solve(new[] { 1, 3, 4 }, 6));
    }
}
