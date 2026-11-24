# DSA Starter Pack (C#)

A ready-made file and xUnit tests for every problem in your 10-week plan (49 problems; Running Sum is already done).

## Setup (one time)

1. Copy the `Solutions` and `Solutions.Tests` folders from this pack into your `dsa-csharp` folder, next to the ones you already have. Let them merge. Nothing you have written gets replaced.
2. Delete `Solutions.Tests/UnitTest1.cs` (the empty sample test).
3. Run `dotnet test`. You should see about 100 failing tests with `NotImplementedException`. That's expected: each one turns green when you solve its problem.
4. Commit: `git add .`, then `git commit -m "Add starter files and tests for all problems"`, then `git push`.

## For every problem

1. Open the problem's file (see the table below). Read the problem on LeetCode.
2. Say your approach and its time/space complexity out loud before writing code.
3. Delete the `throw new NotImplementedException();` line and write your solution.
4. Run only that problem's tests, for example:
   `dotnet test --filter "FullyQualifiedName~ArraysHashing.TwoSumTests"`
5. When the tests pass, copy everything inside `Solve` into the LeetCode method named in the file's header comment, and submit.
6. Commit with a clear message, for example `Add Two Sum (Dictionary, O(n))`, mark it Done in your tracker, and add it to the README table.

The hints at the top of each file go from a small nudge to nearly the whole idea. Only read the next one if you have been stuck for 20+ minutes.

`Solutions/Common/` holds `ListNode`, `TreeNode` and `Node`. They match LeetCode's classes, so linked-list, tree and graph code pastes straight into LeetCode. The extra static helpers in them are only for the tests.

## Problems

### Week 0: Warm-up

| Problem | File | Test filter |
|---|---|---|
| [Fizz Buzz](https://leetcode.com/problems/fizz-buzz/) | `Solutions/Warmup/FizzBuzz.cs` | `Warmup.FizzBuzzTests` |
| [Richest Customer Wealth](https://leetcode.com/problems/richest-customer-wealth/) | `Solutions/Warmup/RichestCustomerWealth.cs` | `Warmup.RichestCustomerWealthTests` |
| [Number of Good Pairs](https://leetcode.com/problems/number-of-good-pairs/) | `Solutions/Warmup/NumberOfGoodPairs.cs` | `Warmup.NumberOfGoodPairsTests` |
| [Reverse String](https://leetcode.com/problems/reverse-string/) | `Solutions/Warmup/ReverseString.cs` | `Warmup.ReverseStringTests` |
| [Merge Sorted Array](https://leetcode.com/problems/merge-sorted-array/) | `Solutions/Warmup/MergeSortedArray.cs` | `Warmup.MergeSortedArrayTests` |

### Week 1: Arrays & Hashing

| Problem | File | Test filter |
|---|---|---|
| [Two Sum](https://leetcode.com/problems/two-sum/) | `Solutions/ArraysHashing/TwoSum.cs` | `ArraysHashing.TwoSumTests` |
| [Contains Duplicate](https://leetcode.com/problems/contains-duplicate/) | `Solutions/ArraysHashing/ContainsDuplicate.cs` | `ArraysHashing.ContainsDuplicateTests` |
| [Valid Anagram](https://leetcode.com/problems/valid-anagram/) | `Solutions/ArraysHashing/ValidAnagram.cs` | `ArraysHashing.ValidAnagramTests` |
| [Group Anagrams](https://leetcode.com/problems/group-anagrams/) | `Solutions/ArraysHashing/GroupAnagrams.cs` | `ArraysHashing.GroupAnagramsTests` |
| [Top K Frequent Elements](https://leetcode.com/problems/top-k-frequent-elements/) | `Solutions/ArraysHashing/TopKFrequentElements.cs` | `ArraysHashing.TopKFrequentElementsTests` |
| [Product of Array Except Self](https://leetcode.com/problems/product-of-array-except-self/) | `Solutions/ArraysHashing/ProductOfArrayExceptSelf.cs` | `ArraysHashing.ProductOfArrayExceptSelfTests` |

### Week 2: Two Pointers & Sliding Window

| Problem | File | Test filter |
|---|---|---|
| [Valid Palindrome](https://leetcode.com/problems/valid-palindrome/) | `Solutions/TwoPointers/ValidPalindrome.cs` | `TwoPointers.ValidPalindromeTests` |
| [Two Sum II - Input Array Is Sorted](https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/) | `Solutions/TwoPointers/TwoSumII.cs` | `TwoPointers.TwoSumIITests` |
| [3Sum](https://leetcode.com/problems/3sum/) | `Solutions/TwoPointers/ThreeSum.cs` | `TwoPointers.ThreeSumTests` |
| [Container With Most Water](https://leetcode.com/problems/container-with-most-water/) | `Solutions/TwoPointers/ContainerWithMostWater.cs` | `TwoPointers.ContainerWithMostWaterTests` |
| [Best Time to Buy and Sell Stock](https://leetcode.com/problems/best-time-to-buy-and-sell-stock/) | `Solutions/TwoPointers/BestTimeToBuyAndSellStock.cs` | `TwoPointers.BestTimeToBuyAndSellStockTests` |
| [Longest Substring Without Repeating Characters](https://leetcode.com/problems/longest-substring-without-repeating-characters/) | `Solutions/TwoPointers/LongestSubstringWithoutRepeating.cs` | `TwoPointers.LongestSubstringWithoutRepeatingTests` |

### Week 3: Stack & Queue

| Problem | File | Test filter |
|---|---|---|
| [Valid Parentheses](https://leetcode.com/problems/valid-parentheses/) | `Solutions/StackQueue/ValidParentheses.cs` | `StackQueue.ValidParenthesesTests` |
| [Min Stack](https://leetcode.com/problems/min-stack/) | `Solutions/StackQueue/MinStack.cs` | `StackQueue.MinStackTests` |
| [Implement Queue using Stacks](https://leetcode.com/problems/implement-queue-using-stacks/) | `Solutions/StackQueue/MyQueue.cs` | `StackQueue.MyQueueTests` |
| [Daily Temperatures](https://leetcode.com/problems/daily-temperatures/) | `Solutions/StackQueue/DailyTemperatures.cs` | `StackQueue.DailyTemperaturesTests` |
| [Evaluate Reverse Polish Notation](https://leetcode.com/problems/evaluate-reverse-polish-notation/) | `Solutions/StackQueue/EvaluateReversePolishNotation.cs` | `StackQueue.EvaluateReversePolishNotationTests` |

### Week 4: Linked Lists

| Problem | File | Test filter |
|---|---|---|
| [Reverse Linked List](https://leetcode.com/problems/reverse-linked-list/) | `Solutions/LinkedLists/ReverseLinkedList.cs` | `LinkedLists.ReverseLinkedListTests` |
| [Merge Two Sorted Lists](https://leetcode.com/problems/merge-two-sorted-lists/) | `Solutions/LinkedLists/MergeTwoSortedLists.cs` | `LinkedLists.MergeTwoSortedListsTests` |
| [Linked List Cycle](https://leetcode.com/problems/linked-list-cycle/) | `Solutions/LinkedLists/LinkedListCycle.cs` | `LinkedLists.LinkedListCycleTests` |
| [Middle of the Linked List](https://leetcode.com/problems/middle-of-the-linked-list/) | `Solutions/LinkedLists/MiddleOfLinkedList.cs` | `LinkedLists.MiddleOfLinkedListTests` |
| [Remove Nth Node From End of List](https://leetcode.com/problems/remove-nth-node-from-end-of-list/) | `Solutions/LinkedLists/RemoveNthNodeFromEnd.cs` | `LinkedLists.RemoveNthNodeFromEndTests` |
| [Reorder List](https://leetcode.com/problems/reorder-list/) | `Solutions/LinkedLists/ReorderList.cs` | `LinkedLists.ReorderListTests` |

### Week 5: Recursion & Binary Search

| Problem | File | Test filter |
|---|---|---|
| [Fibonacci Number](https://leetcode.com/problems/fibonacci-number/) | `Solutions/RecursionBinarySearch/FibonacciNumber.cs` | `RecursionBinarySearch.FibonacciNumberTests` |
| [Climbing Stairs](https://leetcode.com/problems/climbing-stairs/) | `Solutions/RecursionBinarySearch/ClimbingStairs.cs` | `RecursionBinarySearch.ClimbingStairsTests` |
| [Pow(x, n)](https://leetcode.com/problems/powx-n/) | `Solutions/RecursionBinarySearch/PowXN.cs` | `RecursionBinarySearch.PowXNTests` |
| [Binary Search](https://leetcode.com/problems/binary-search/) | `Solutions/RecursionBinarySearch/BinarySearch.cs` | `RecursionBinarySearch.BinarySearchTests` |
| [Search Insert Position](https://leetcode.com/problems/search-insert-position/) | `Solutions/RecursionBinarySearch/SearchInsertPosition.cs` | `RecursionBinarySearch.SearchInsertPositionTests` |
| [Search in Rotated Sorted Array](https://leetcode.com/problems/search-in-rotated-sorted-array/) | `Solutions/RecursionBinarySearch/SearchInRotatedSortedArray.cs` | `RecursionBinarySearch.SearchInRotatedSortedArrayTests` |

### Week 6: Trees

| Problem | File | Test filter |
|---|---|---|
| [Maximum Depth of Binary Tree](https://leetcode.com/problems/maximum-depth-of-binary-tree/) | `Solutions/Trees/MaximumDepthOfBinaryTree.cs` | `Trees.MaximumDepthOfBinaryTreeTests` |
| [Invert Binary Tree](https://leetcode.com/problems/invert-binary-tree/) | `Solutions/Trees/InvertBinaryTree.cs` | `Trees.InvertBinaryTreeTests` |
| [Same Tree](https://leetcode.com/problems/same-tree/) | `Solutions/Trees/SameTree.cs` | `Trees.SameTreeTests` |
| [Binary Tree Level Order Traversal](https://leetcode.com/problems/binary-tree-level-order-traversal/) | `Solutions/Trees/BinaryTreeLevelOrderTraversal.cs` | `Trees.BinaryTreeLevelOrderTraversalTests` |
| [Validate Binary Search Tree](https://leetcode.com/problems/validate-binary-search-tree/) | `Solutions/Trees/ValidateBinarySearchTree.cs` | `Trees.ValidateBinarySearchTreeTests` |
| [Lowest Common Ancestor of a Binary Search Tree](https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/) | `Solutions/Trees/LowestCommonAncestorOfBST.cs` | `Trees.LowestCommonAncestorOfBSTTests` |

### Week 7: Heaps & Graphs

| Problem | File | Test filter |
|---|---|---|
| [Kth Largest Element in an Array](https://leetcode.com/problems/kth-largest-element-in-an-array/) | `Solutions/HeapsGraphs/KthLargestElement.cs` | `HeapsGraphs.KthLargestElementTests` |
| [Last Stone Weight](https://leetcode.com/problems/last-stone-weight/) | `Solutions/HeapsGraphs/LastStoneWeight.cs` | `HeapsGraphs.LastStoneWeightTests` |
| [Number of Islands](https://leetcode.com/problems/number-of-islands/) | `Solutions/HeapsGraphs/NumberOfIslands.cs` | `HeapsGraphs.NumberOfIslandsTests` |
| [Clone Graph](https://leetcode.com/problems/clone-graph/) | `Solutions/HeapsGraphs/CloneGraph.cs` | `HeapsGraphs.CloneGraphTests` |
| [Course Schedule](https://leetcode.com/problems/course-schedule/) | `Solutions/HeapsGraphs/CourseSchedule.cs` | `HeapsGraphs.CourseScheduleTests` |

### Week 8: Dynamic Programming

| Problem | File | Test filter |
|---|---|---|
| [House Robber](https://leetcode.com/problems/house-robber/) | `Solutions/DynamicProgramming/HouseRobber.cs` | `DynamicProgramming.HouseRobberTests` |
| [Coin Change](https://leetcode.com/problems/coin-change/) | `Solutions/DynamicProgramming/CoinChange.cs` | `DynamicProgramming.CoinChangeTests` |
| [Unique Paths](https://leetcode.com/problems/unique-paths/) | `Solutions/DynamicProgramming/UniquePaths.cs` | `DynamicProgramming.UniquePathsTests` |
| [Longest Common Subsequence](https://leetcode.com/problems/longest-common-subsequence/) | `Solutions/DynamicProgramming/LongestCommonSubsequence.cs` | `DynamicProgramming.LongestCommonSubsequenceTests` |
