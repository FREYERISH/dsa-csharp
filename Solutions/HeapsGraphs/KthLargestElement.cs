namespace Solutions.HeapsGraphs;

// Kth Largest Element in an Array (Medium)
// https://leetcode.com/problems/kth-largest-element-in-an-array/
// On LeetCode, the method is called: FindKthLargest  (copy everything inside Solve)
//
// Before coding, say out loud: your approach, then time and space complexity.
//
// Hints (read one at a time, only if you're stuck for 20+ minutes):
//   1. Easy version: sort and pick. O(n log n). Say it, then improve it.
//   2. Keep a min-heap (PriorityQueue<int, int>, using the number as its own priority) of the k largest numbers seen so far.
//   3. Add each number; if the heap has more than k items, Dequeue the smallest. At the end, Peek() is the answer. O(n log k).
public class KthLargestElement
{
    public int Solve(int[] nums, int k)
    {
        // TODO: write your solution here, then delete the line below.
        throw new NotImplementedException();
    }
}
