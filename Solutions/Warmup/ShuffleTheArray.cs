namespace Solutions.Warmup;

// Shuffle the Array (Easy)
// https://leetcode.com/problems/shuffle-the-array/
// On LeetCode, the method is called: Shuffle  (copy everything inside Solve)
//
// Before coding, say out loud: your approach, then time and space complexity.
//
// Hints (read one at a time, only if you're stuck for 20+ minutes):
//   1. nums is [x1, x2, ..., xn, y1, y2, ..., yn]. The answer is [x1, y1, x2, y2, ...].
//   2. Loop i from 0 to n - 1. The x is nums[i] and the y is nums[i + n].
//   3. Where do they go in the answer? Work it out for i = 0, 1, 2 on paper: positions 2 * i and 2 * i + 1.

// Input: nums = [2,5,1,3,4,7], n = 3
// Output: [2,3,5,4,1,7] 

public class ShuffleTheArray
{
    public int[] Solve(int[] nums, int n)
    {
        int[] ans = new int[2*n]; 
        for(int i=0; i<2* n; i++)
        {
            if(i%2 == 0)
            {
                ans[i] = nums [i/2];
            }
            else
            {
                ans[i] = nums[ n+i /2];
            }
        }
        return ans;
    }
}
