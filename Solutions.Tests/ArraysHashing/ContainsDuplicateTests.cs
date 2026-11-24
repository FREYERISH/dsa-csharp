using Solutions.ArraysHashing;

namespace Solutions.Tests.ArraysHashing;

public class ContainsDuplicateTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new ContainsDuplicate();
        Assert.True(solver.Solve(new[] { 1, 2, 3, 1 }));
        Assert.False(solver.Solve(new[] { 1, 2, 3, 4 }));
        Assert.True(solver.Solve(new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }));
    }
}
