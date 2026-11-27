namespace Solutions.Warmup;

// Merge Sorted Array (Easy)
// https://leetcode.com/problems/merge-sorted-array/
// On LeetCode, the method is called: Merge  (copy everything inside Solve)
//
// Before coding, say out loud: your approach, then time and space complexity.
//
// Hints (read one at a time, only if you're stuck for 20+ minutes):
//   1. nums1 has room for both arrays: its last n slots are empty (zeros).
//   2. Filling from the FRONT would overwrite numbers you still need. Fill from the BACK instead.
//   3. Three indexes: i = m - 1 (end of real nums1 values), j = n - 1 (end of nums2), k = m + n - 1 (where to write).
//   4. Each step, write the bigger of nums1[i] and nums2[j] at k. Stop when nums2 is used up.
public class MergeSortedArray
{
    public void Solve(int[] nums1, int m, int[] nums2, int n)
{
    int i = m - 1;
    int j = n - 1;
    int k = m + n - 1;

    while (j >= 0) {
        // TODO:
        // if i is still valid (i >= 0) AND nums1[i] > nums2[j]:
        //     write nums1[i] at nums1[k], move i left
        // otherwise:
        //     write nums2[j] at nums1[k], move j left
        // move k left (in both cases)
        if(i>= 0 && nums1[i]> nums2[j]){
                nums1[k] = nums1[i];
                i--;
                k--;
            }
            else
            {
                nums1[k] = nums2[j];
                        j--;
                        k--;
        }


    }
}
}
