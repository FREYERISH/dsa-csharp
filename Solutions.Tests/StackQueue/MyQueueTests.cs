using Solutions.StackQueue;

namespace Solutions.Tests.StackQueue;

public class MyQueueTests
{
    [Fact]
    public void LeetCodeExample()
    {
        var queue = new MyQueue();
        queue.Push(1);
        queue.Push(2);
        Assert.Equal(1, queue.Peek());
        Assert.Equal(1, queue.Pop());
        Assert.False(queue.Empty());
        Assert.Equal(2, queue.Pop());
        Assert.True(queue.Empty());
    }

    [Fact]
    public void PushAfterPop_KeepsOrder()
    {
        var queue = new MyQueue();
        queue.Push(1);
        queue.Push(2);
        Assert.Equal(1, queue.Pop());
        queue.Push(3);
        Assert.Equal(2, queue.Pop());
        Assert.Equal(3, queue.Pop());
    }
}
