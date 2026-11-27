using Solutions.Warmup;

namespace Solutions.Tests.Warmup;

public class JewelsAndStonesTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new JewelsAndStones();
        Assert.Equal(3, solver.Solve("aA", "aAAbbbb"));
        Assert.Equal(0, solver.Solve("z", "ZZ"));
    }
}
