using Solutions.Warmup;

namespace Solutions.Tests.Warmup;

public class MergeSortedArrayTests
{
    [Fact]
    public void Solve_LeetCodeExample1()
    {
        int[] nums1 = { 1, 2, 3, 0, 0, 0 };
        new MergeSortedArray().Solve(nums1, 3, new[] { 2, 5, 6 }, 3);
        Assert.Equal(new[] { 1, 2, 2, 3, 5, 6 }, nums1);
    }

    [Fact]
    public void Solve_SecondArrayEmpty()
    {
        int[] nums1 = { 1 };
        new MergeSortedArray().Solve(nums1, 1, new int[0], 0);
        Assert.Equal(new[] { 1 }, nums1);
    }

    [Fact]
    public void Solve_FirstArrayEmpty()
    {
        int[] nums1 = { 0 };
        new MergeSortedArray().Solve(nums1, 0, new[] { 1 }, 1);
        Assert.Equal(new[] { 1 }, nums1);
    }
}
