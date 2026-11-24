namespace Solutions.HeapsGraphs;

// Course Schedule (Medium)
// https://leetcode.com/problems/course-schedule/
// On LeetCode, the method is called: CanFinish  (copy everything inside Solve)
//
// Before coding, say out loud: your approach, then time and space complexity.
//
// Hints (read one at a time, only if you're stuck for 20+ minutes):
//   1. Courses are nodes; [a, b] means an edge b -> a (take b before a).
//   2. You can finish every course unless the graph has a CYCLE.
//   3. Kahn's algorithm: count incoming edges for each course. Queue every course with 0. Each time you take one, reduce its neighbours' counts and queue any that hit 0.
//   4. If the number of courses taken == numCourses, return true.
public class CourseSchedule
{
    public bool Solve(int numCourses, int[][] prerequisites)
    {
        // TODO: write your solution here, then delete the line below.
        throw new NotImplementedException();
    }
}
