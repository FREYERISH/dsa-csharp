using Solutions.Warmup;

namespace Solutions.Tests.Warmup;

public class FirstUniqueCharacterTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new FirstUniqueCharacter();
        Assert.Equal(0, solver.Solve("leetcode"));
        Assert.Equal(2, solver.Solve("loveleetcode"));
        Assert.Equal(-1, solver.Solve("aabb"));
    }
}
