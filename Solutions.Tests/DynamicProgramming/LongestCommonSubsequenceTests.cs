using Solutions.DynamicProgramming;

namespace Solutions.Tests.DynamicProgramming;

public class LongestCommonSubsequenceTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new LongestCommonSubsequence();
        Assert.Equal(3, solver.Solve("abcde", "ace"));
        Assert.Equal(3, solver.Solve("abc", "abc"));
        Assert.Equal(0, solver.Solve("abc", "def"));
    }
}
