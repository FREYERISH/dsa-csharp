using Solutions.ArraysHashing;

namespace Solutions.Tests.ArraysHashing;

public class TwoSumTests
{
    private static int[] Sorted(int[] values)
    {
        int[] copy = (int[])values.Clone();
        Array.Sort(copy);
        return copy;
    }

    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new TwoSum();
        Assert.Equal(new[] { 0, 1 }, Sorted(solver.Solve(new[] { 2, 7, 11, 15 }, 9)));
        Assert.Equal(new[] { 1, 2 }, Sorted(solver.Solve(new[] { 3, 2, 4 }, 6)));
        Assert.Equal(new[] { 0, 1 }, Sorted(solver.Solve(new[] { 3, 3 }, 6)));
    }
}
