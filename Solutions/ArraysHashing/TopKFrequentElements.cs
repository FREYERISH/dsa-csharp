namespace Solutions.ArraysHashing;

// Top K Frequent Elements (Medium)
// https://leetcode.com/problems/top-k-frequent-elements/
// On LeetCode, the method is called: TopKFrequent  (copy everything inside Solve)
//
// Before coding, say out loud: your approach, then time and space complexity.
//
// Hints (read one at a time, only if you're stuck for 20+ minutes):
//   1. Step 1: count each number with a Dictionary<int, int>.
//   2. Step 2 (simple): sort the dictionary entries by count, descending, and take k. That's O(n log n).
//   3. Step 2 (better, O(n)): bucket sort. Make a list for every possible count 0..n, put each number in buckets[count], then walk from the highest bucket down.
public class TopKFrequentElements
{
    public int[] Solve(int[] nums, int k)
    {
        // TODO: write your solution here, then delete the line below.
        throw new NotImplementedException();
    }
}
