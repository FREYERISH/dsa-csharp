namespace Solutions.Warmup;

// Concatenation of Array (Easy)
// https://leetcode.com/problems/concatenation-of-array/
// On LeetCode, the method is called: GetConcatenation  (copy everything inside Solve)
//
// Before coding, say out loud: your approach, then time and space complexity.
//
// Hints (read one at a time, only if you're stuck for 20+ minutes):
//   1. The answer is twice as long as nums: new int[nums.Length * 2].
//   2. One loop over nums is enough: write nums[i] into TWO places in the answer.
//   3. The second copy of nums[i] goes at position i + nums.Length.
public class ConcatenationOfArray
{
    public int[] Solve(int[] nums)
    {
        int  n = 2*nums.Length;
        int[] ans = new int[n];

        for(int i = 0; i < n; i++)
        {
            if (i < nums.Length)
            {
                ans[i] = nums[i];
            }
            else
            {
                ans[i] = nums[i-nums.Length];
            }
        }

        return ans;

    }
}
