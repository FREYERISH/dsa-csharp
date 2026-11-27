using Solutions.Warmup;

namespace Solutions.Tests.Warmup;

public class RansomNoteTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new RansomNote();
        Assert.False(solver.Solve("a", "b"));
        Assert.False(solver.Solve("aa", "ab"));
        Assert.True(solver.Solve("aa", "aab"));
    }
}
