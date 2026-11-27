namespace Solutions.Warmup;

// Richest Customer Wealth (Easy)
// https://leetcode.com/problems/richest-customer-wealth/
// On LeetCode, the method is called: MaximumWealth  (copy everything inside Solve)
//
// Before coding, say out loud: your approach, then time and space complexity.
//
// Hints (read one at a time, only if you're stuck for 20+ minutes):
//   1. accounts[i] is one customer; accounts[i][j] is one of their bank accounts.
//   2. For each customer, add up their accounts (inner loop).
//   3. Keep track of the largest total you have seen.
public class RichestCustomerWealth
{
    public int Solve(int[][] accounts)
    {
        int count = 0;
        int result = 0;
        for (int i = 0; i < accounts.Length; i++)
        {
            for (int j = 0; j < accounts[i].Length; j++)
            {
                count = count + accounts[i][j];
            }
            if (result <= count)
            {
                result = count;
            }
            count = 0;
        }
        return result;
    }
}
