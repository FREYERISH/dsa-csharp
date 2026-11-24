using Solutions.StackQueue;

namespace Solutions.Tests.StackQueue;

public class DailyTemperaturesTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new DailyTemperatures();
        Assert.Equal(new[] { 1, 1, 4, 2, 1, 1, 0, 0 }, solver.Solve(new[] { 73, 74, 75, 71, 69, 72, 76, 73 }));
        Assert.Equal(new[] { 1, 1, 1, 0 }, solver.Solve(new[] { 30, 40, 50, 60 }));
        Assert.Equal(new[] { 1, 1, 0 }, solver.Solve(new[] { 30, 60, 90 }));
    }
}
