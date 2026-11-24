using Solutions.ArraysHashing;

namespace Solutions.Tests.ArraysHashing;

public class ProductOfArrayExceptSelfTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new ProductOfArrayExceptSelf();
        Assert.Equal(new[] { 24, 12, 8, 6 }, solver.Solve(new[] { 1, 2, 3, 4 }));
        Assert.Equal(new[] { 0, 0, 9, 0, 0 }, solver.Solve(new[] { -1, 1, 0, -3, 3 }));
    }
}
