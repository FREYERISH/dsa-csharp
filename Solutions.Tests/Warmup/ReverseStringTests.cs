using Solutions.Warmup;

namespace Solutions.Tests.Warmup;

public class ReverseStringTests
{
    [Fact]
    public void Solve_Hello()
    {
        char[] s = "hello".ToCharArray();
        new ReverseString().Solve(s);
        Assert.Equal("olleh", new string(s));
    }

    [Fact]
    public void Solve_Hannah()
    {
        char[] s = "Hannah".ToCharArray();
        new ReverseString().Solve(s);
        Assert.Equal("hannaH", new string(s));
    }

    [Fact]
    public void Solve_SingleCharacter()
    {
        char[] s = { 'a' };
        new ReverseString().Solve(s);
        Assert.Equal("a", new string(s));
    }
}
