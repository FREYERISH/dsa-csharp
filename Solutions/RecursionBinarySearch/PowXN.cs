namespace Solutions.RecursionBinarySearch;

// Pow(x, n) (Medium)
// https://leetcode.com/problems/powx-n/
// On LeetCode, the method is called: MyPow  (copy everything inside Solve)
//
// Before coding, say out loud: your approach, then time and space complexity.
//
// Hints (read one at a time, only if you're stuck for 20+ minutes):
//   1. Multiplying x by itself n times is too slow when n is 2 billion.
//   2. Recursion: x^n = (x^(n/2))^2 for even n, and x * (x^(n/2))^2 for odd n. Each call halves n: O(log n).
//   3. Negative n: x^-n = 1 / x^n.
//   4. Trap: -int.MinValue doesn't fit in an int. Copy n into a long first.
public class PowXN
{
    public double Solve(double x, int n)
    {
        // TODO: write your solution here, then delete the line below.
        throw new NotImplementedException();
    }
}
