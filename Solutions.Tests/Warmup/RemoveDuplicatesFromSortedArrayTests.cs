using Solutions.Warmup;

namespace Solutions.Tests.Warmup;

public class RemoveDuplicatesFromSortedArrayTests
{
    [Fact]
    public void Solve_LeetCodeExample1()
    {
        int[] nums = { 1, 1, 2 };
        int k = new RemoveDuplicatesFromSortedArray().Solve(nums);
        Assert.Equal(2, k);
        Assert.Equal(new[] { 1, 2 }, nums.Take(k).ToArray());
    }

    [Fact]
    public void Solve_LeetCodeExample2()
    {
        int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        int k = new RemoveDuplicatesFromSortedArray().Solve(nums);
        Assert.Equal(5, k);
        Assert.Equal(new[] { 0, 1, 2, 3, 4 }, nums.Take(k).ToArray());
    }
}
