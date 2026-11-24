using Solutions.Warmup;

namespace Solutions.Tests.Warmup;

public class FizzBuzzTests
{
    [Fact]
    public void Solve_UpToThree()
    {
        Assert.Equal(new[] { "1", "2", "Fizz" }, new FizzBuzz().Solve(3).ToArray());
    }

    [Fact]
    public void Solve_UpToFive()
    {
        Assert.Equal(new[] { "1", "2", "Fizz", "4", "Buzz" }, new FizzBuzz().Solve(5).ToArray());
    }

    [Fact]
    public void Solve_FifteenIsFizzBuzz()
    {
        var result = new FizzBuzz().Solve(15);
        Assert.Equal(15, result.Count);
        Assert.Equal("FizzBuzz", result[14]);
    }
}
