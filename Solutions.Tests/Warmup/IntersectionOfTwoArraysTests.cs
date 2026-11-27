using Solutions.Warmup;

namespace Solutions.Tests.Warmup;

public class IntersectionOfTwoArraysTests
{
    // Any order is accepted, so sort before comparing.
    private static int[] Sorted(int[] values)
    {
        int[] copy = (int[])values.Clone();
        Array.Sort(copy);
        return copy;
    }

    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new IntersectionOfTwoArrays();
        Assert.Equal(new[] { 2 }, Sorted(solver.Solve(new[] { 1, 2, 2, 1 }, new[] { 2, 2 })));
        Assert.Equal(new[] { 4, 9 }, Sorted(solver.Solve(new[] { 4, 9, 5 }, new[] { 9, 4, 9, 8, 4 })));
    }

    [Fact]
    public void Solve_NothingInCommon()
    {
        Assert.Empty(new IntersectionOfTwoArrays().Solve(new[] { 1, 2 }, new[] { 3, 4 }));
    }
}
