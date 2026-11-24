using Solutions.HeapsGraphs;

namespace Solutions.Tests.HeapsGraphs;

public class NumberOfIslandsTests
{
    private static char[][] Grid(params string[] rows) => rows.Select(r => r.ToCharArray()).ToArray();

    [Fact]
    public void Solve_OneIsland()
    {
        var grid = Grid("11110", "11010", "11000", "00000");
        Assert.Equal(1, new NumberOfIslands().Solve(grid));
    }

    [Fact]
    public void Solve_ThreeIslands()
    {
        var grid = Grid("11000", "11000", "00100", "00011");
        Assert.Equal(3, new NumberOfIslands().Solve(grid));
    }

    [Fact]
    public void Solve_NoLand()
    {
        Assert.Equal(0, new NumberOfIslands().Solve(Grid("000", "000")));
    }
}
