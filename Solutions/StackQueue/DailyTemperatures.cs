namespace Solutions.StackQueue;

// Daily Temperatures (Medium)
// https://leetcode.com/problems/daily-temperatures/
// On LeetCode, the method is called: DailyTemperatures  (copy everything inside Solve)
//
// Before coding, say out loud: your approach, then time and space complexity.
//
// Hints (read one at a time, only if you're stuck for 20+ minutes):
//   1. Brute force: for each day, scan forward for a warmer day. O(n^2). Say it, then improve it.
//   2. Keep a Stack<int> of day INDEXES that are still waiting for a warmer day.
//   3. For each new day i: while the stack isn't empty and temperatures[i] is warmer than the day on top, pop that day and set answer[day] = i - day. Then push i.
public class DailyTemperatures
{
    public int[] Solve(int[] temperatures)
    {
        // TODO: write your solution here, then delete the line below.
        throw new NotImplementedException();
    }
}
