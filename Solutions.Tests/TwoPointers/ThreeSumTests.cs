using Solutions.TwoPointers;

namespace Solutions.Tests.TwoPointers;

public class ThreeSumTests
{
    // Order doesn't matter, so sort everything before comparing.
    private static string Normalize(IList<IList<int>> triplets) =>
        string.Join("|", triplets.Select(t => string.Join(",", t.OrderBy(x => x))).OrderBy(t => t));

    [Fact]
    public void Solve_LeetCodeExample1()
    {
        var result = new ThreeSum().Solve(new[] { -1, 0, 1, 2, -1, -4 });
        Assert.Equal("-1,-1,2|-1,0,1", Normalize(result));
    }

    [Fact]
    public void Solve_NoTriplets()
    {
        Assert.Empty(new ThreeSum().Solve(new[] { 0, 1, 1 }));
    }

    [Fact]
    public void Solve_AllZeros_NoDuplicateTriplets()
    {
        Assert.Equal("0,0,0", Normalize(new ThreeSum().Solve(new[] { 0, 0, 0, 0 })));
    }
}
