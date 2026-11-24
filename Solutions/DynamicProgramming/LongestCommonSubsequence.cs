namespace Solutions.DynamicProgramming;

// Longest Common Subsequence (Medium)
// https://leetcode.com/problems/longest-common-subsequence/
// On LeetCode, the method is called: LongestCommonSubsequence  (copy everything inside Solve)
//
// Before coding, say out loud: your approach, then time and space complexity.
//
// Hints (read one at a time, only if you're stuck for 20+ minutes):
//   1. 2D table: dp[i, j] = LCS of the first i letters of text1 and the first j letters of text2. Size (len1 + 1) x (len2 + 1).
//   2. If text1[i - 1] == text2[j - 1]: dp[i, j] = dp[i - 1, j - 1] + 1.
//   3. Otherwise: dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]).
//   4. Draw the table for "abcde" / "ace" by hand first.
public class LongestCommonSubsequence
{
    public int Solve(string text1, string text2)
    {
        // TODO: write your solution here, then delete the line below.
        throw new NotImplementedException();
    }
}
