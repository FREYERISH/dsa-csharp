using Solutions.StackQueue;

namespace Solutions.Tests.StackQueue;

public class EvaluateReversePolishNotationTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new EvaluateReversePolishNotation();
        Assert.Equal(9, solver.Solve(new[] { "2", "1", "+", "3", "*" }));
        Assert.Equal(6, solver.Solve(new[] { "4", "13", "5", "/", "+" }));
        Assert.Equal(22, solver.Solve(new[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" }));
    }
}
