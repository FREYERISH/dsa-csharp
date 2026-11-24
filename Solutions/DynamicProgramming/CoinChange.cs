namespace Solutions.DynamicProgramming;

// Coin Change (Medium)
// https://leetcode.com/problems/coin-change/
// On LeetCode, the method is called: CoinChange  (copy everything inside Solve)
//
// Before coding, say out loud: your approach, then time and space complexity.
//
// Hints (read one at a time, only if you're stuck for 20+ minutes):
//   1. dp[a] = the fewest coins that make amount a. dp[0] = 0.
//   2. Fill dp[1] to dp[amount] with a big value (amount + 1 works as 'impossible').
//   3. For each a and each coin <= a: dp[a] = Math.Min(dp[a], dp[a - coin] + 1).
//   4. If dp[amount] is still 'impossible', return -1.
public class CoinChange
{
    public int Solve(int[] coins, int amount)
    {
        // TODO: write your solution here, then delete the line below.
        throw new NotImplementedException();
    }
}
