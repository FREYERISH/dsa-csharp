using Solutions.StackQueue;

namespace Solutions.Tests.StackQueue;

public class MinStackTests
{
    [Fact]
    public void LeetCodeExample()
    {
        var stack = new MinStack();
        stack.Push(-2);
        stack.Push(0);
        stack.Push(-3);
        Assert.Equal(-3, stack.GetMin());
        stack.Pop();
        Assert.Equal(0, stack.Top());
        Assert.Equal(-2, stack.GetMin());
    }

    [Fact]
    public void DuplicateMinimums()
    {
        var stack = new MinStack();
        stack.Push(1);
        stack.Push(1);
        stack.Pop();
        Assert.Equal(1, stack.GetMin());
    }
}
