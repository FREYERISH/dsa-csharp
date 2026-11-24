namespace Solutions.TwoPointers;

// Longest Substring Without Repeating Characters (Medium)
// https://leetcode.com/problems/longest-substring-without-repeating-characters/
// On LeetCode, the method is called: LengthOfLongestSubstring  (copy everything inside Solve)
//
// Before coding, say out loud: your approach, then time and space complexity.
//
// Hints (read one at a time, only if you're stuck for 20+ minutes):
//   1. Sliding window: a left edge and a right edge, plus a HashSet<char> of what's inside the window.
//   2. Move right one step at a time. If s[right] is already in the set, remove s[left] and move left up until it isn't.
//   3. After adding s[right], the window size is right - left + 1. Keep the biggest.
public class LongestSubstringWithoutRepeating
{
    public int Solve(string s)
    {
        // TODO: write your solution here, then delete the line below.
        throw new NotImplementedException();
    }
}
