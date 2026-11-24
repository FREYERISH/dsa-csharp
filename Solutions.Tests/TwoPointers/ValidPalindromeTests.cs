using Solutions.TwoPointers;

namespace Solutions.Tests.TwoPointers;

public class ValidPalindromeTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new ValidPalindrome();
        Assert.True(solver.Solve("A man, a plan, a canal: Panama"));
        Assert.False(solver.Solve("race a car"));
        Assert.True(solver.Solve(" "));
    }

    [Fact]
    public void Solve_DigitsCount()
    {
        Assert.False(new ValidPalindrome().Solve("0P"));
    }
}
