using Solutions.TwoPointers;

namespace Solutions.Tests.TwoPointers;

public class LongestSubstringWithoutRepeatingTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new LongestSubstringWithoutRepeating();
        Assert.Equal(3, solver.Solve("abcabcbb"));
        Assert.Equal(1, solver.Solve("bbbbb"));
        Assert.Equal(3, solver.Solve("pwwkew"));
    }

    [Fact]
    public void Solve_EmptyString()
    {
        Assert.Equal(0, new LongestSubstringWithoutRepeating().Solve(""));
    }
}
