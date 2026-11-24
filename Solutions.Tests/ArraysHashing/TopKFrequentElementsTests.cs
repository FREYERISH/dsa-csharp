using Solutions.ArraysHashing;

namespace Solutions.Tests.ArraysHashing;

public class TopKFrequentElementsTests
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
        var solver = new TopKFrequentElements();
        Assert.Equal(new[] { 1, 2 }, Sorted(solver.Solve(new[] { 1, 1, 1, 2, 2, 3 }, 2)));
        Assert.Equal(new[] { 1 }, Sorted(solver.Solve(new[] { 1 }, 1)));
    }

    [Fact]
    public void Solve_NegativeNumbers()
    {
        Assert.Equal(new[] { -1 }, Sorted(new TopKFrequentElements().Solve(new[] { 4, -1, -1, 2, -1, 2 }, 1)));
    }
}
