using Solutions.Warmup;

namespace Solutions.Tests.Warmup;

public class MoveZeroesTests
{
    [Fact]
    public void Solve_LeetCodeExample1()
    {
        int[] nums = { 0, 1, 0, 3, 12 };
        new MoveZeroes().Solve(nums);
        Assert.Equal(new[] { 1, 3, 12, 0, 0 }, nums);
    }

    [Fact]
    public void Solve_SingleZero()
    {
        int[] nums = { 0 };
        new MoveZeroes().Solve(nums);
        Assert.Equal(new[] { 0 }, nums);
    }

    [Fact]
    public void Solve_NoZeros()
    {
        int[] nums = { 4, 2, 7 };
        new MoveZeroes().Solve(nums);
        Assert.Equal(new[] { 4, 2, 7 }, nums);
    }
}
