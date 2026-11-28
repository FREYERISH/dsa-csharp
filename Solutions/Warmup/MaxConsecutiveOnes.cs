namespace Solutions.Warmup;

// Max Consecutive Ones (Easy)
// https://leetcode.com/problems/max-consecutive-ones/
// On LeetCode, the method is called: FindMaxConsecutiveOnes  (copy everything inside Solve)
//
// Before coding, say out loud: your approach, then time and space complexity.
//
// Hints (read one at a time, only if you're stuck for 20+ minutes):
//   1. Two variables: current (the length of the run of 1s you're in now) and best.
//   2. See a 1: current goes up by 1, then update best. See a 0: current goes back to 0.
//   3. This is the same 'running value + best so far' idea as Richest Customer Wealth.
public class MaxConsecutiveOnes
{
    public int Solve(int[] nums)
    {
        int current = 0;
        int  best = 0;
        foreach(int n in nums)
        {
            if(n == 1)
            {
                current++;
            }
            else
            {
                current = 0;
            }
            if(current >= best)
            {
                best = current;
            }
        }
        return best;
    }
}
