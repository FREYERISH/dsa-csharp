namespace Solutions.Warmup;

// Number of Good Pairs (Easy)
// https://leetcode.com/problems/number-of-good-pairs/
// On LeetCode, the method is called: NumIdenticalPairs  (copy everything inside Solve)
//
// Before coding, say out loud: your approach, then time and space complexity.
//
// Hints (read one at a time, only if you're stuck for 20+ minutes):
//   1. A good pair is i < j with nums[i] == nums[j].
//   2. Simple version: two nested loops, O(n^2). Get that working first.
//   3. Better: a Dictionary<int, int> of how many times you have seen each value. When you see a value again, every earlier copy makes a new pair.
public class NumberOfGoodPairs
{
    public int Solve(int[] nums)
    {
        Dictionary<int, int> seen = new Dictionary<int, int>();
        int pairs = 0;

        foreach (int n in nums)
        {

            if (seen.ContainsKey(n))
            {
                pairs = pairs + seen[n];
                seen[n] = seen[n] + 1;
            }
            else
            {
             seen[n] =1;   
            }
        }

        return pairs;
    }
}
