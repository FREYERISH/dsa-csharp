using Solutions.HeapsGraphs;

namespace Solutions.Tests.HeapsGraphs;

public class CourseScheduleTests
{
    [Fact]
    public void Solve_LeetCodeExamples()
    {
        var solver = new CourseSchedule();
        Assert.True(solver.Solve(2, new[] { new[] { 1, 0 } }));
        Assert.False(solver.Solve(2, new[] { new[] { 1, 0 }, new[] { 0, 1 } }));
    }

    [Fact]
    public void Solve_LargerGraphWithoutCycle()
    {
        var prerequisites = new[] { new[] { 1, 4 }, new[] { 2, 4 }, new[] { 3, 1 }, new[] { 3, 2 } };
        Assert.True(new CourseSchedule().Solve(5, prerequisites));
    }

    [Fact]
    public void Solve_NoPrerequisites()
    {
        Assert.True(new CourseSchedule().Solve(3, new int[0][]));
    }
}
