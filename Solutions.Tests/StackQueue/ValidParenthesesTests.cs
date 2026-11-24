using Solutions.StackQueue;

namespace Solutions.Tests.StackQueue;

public class ValidParenthesesTests
{
    [Fact]
    public void Solve_ValidStrings()
    {
        var solver = new ValidParentheses();
        Assert.True(solver.Solve("()"));
        Assert.True(solver.Solve("()[]{}"));
        Assert.True(solver.Solve("{[]}"));
    }

    [Fact]
    public void Solve_InvalidStrings()
    {
        var solver = new ValidParentheses();
        Assert.False(solver.Solve("(]"));
        Assert.False(solver.Solve("([)]"));
        Assert.False(solver.Solve("("));
        Assert.False(solver.Solve("]"));
    }
}
