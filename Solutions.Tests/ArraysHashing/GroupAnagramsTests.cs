using Solutions.ArraysHashing;

namespace Solutions.Tests.ArraysHashing;

public class GroupAnagramsTests
{
    // Order doesn't matter, so sort everything before comparing.
    private static string Normalize(IList<IList<string>> groups) =>
        string.Join("|", groups.Select(g => string.Join(",", g.OrderBy(w => w))).OrderBy(g => g));

    [Fact]
    public void Solve_LeetCodeExample1()
    {
        var result = new GroupAnagrams().Solve(new[] { "eat", "tea", "tan", "ate", "nat", "bat" });
        Assert.Equal("ate,eat,tea|bat|nat,tan", Normalize(result));
    }

    [Fact]
    public void Solve_EmptyString()
    {
        var result = new GroupAnagrams().Solve(new[] { "" });
        Assert.Single(result);
        Assert.Equal("", result[0][0]);
    }

    [Fact]
    public void Solve_SingleWord()
    {
        Assert.Equal("a", Normalize(new GroupAnagrams().Solve(new[] { "a" })));
    }
}
