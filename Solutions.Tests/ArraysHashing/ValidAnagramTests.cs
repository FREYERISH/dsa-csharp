using Solutions.ArraysHashing;

namespace Solutions.Tests.ArraysHashing;

public class ValidAnagramTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new ValidAnagram();
        Assert.True(solver.Solve("anagram", "nagaram"));
        Assert.False(solver.Solve("rat", "car"));
    }

    [Fact]
    public void Solve_DifferentLengths()
    {
        Assert.False(new ValidAnagram().Solve("a", "ab"));
    }
}
