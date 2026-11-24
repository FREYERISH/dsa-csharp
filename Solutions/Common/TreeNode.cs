#nullable disable
namespace Solutions.Common;

// Same shape as LeetCode's TreeNode, so your code pastes straight into LeetCode.
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    // ---- Helpers for the tests (not part of LeetCode) ----

    // Builds a tree from LeetCode's level-order format, e.g. [3, 9, 20, null, null, 15, 7].
    public static TreeNode FromLevelOrder(params int?[] values)
    {
        if (values.Length == 0 || values[0] == null) return null;

        TreeNode root = new TreeNode(values[0].Value);
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int i = 1;
        while (queue.Count > 0 && i < values.Length)
        {
            TreeNode node = queue.Dequeue();
            if (i < values.Length && values[i] != null)
            {
                node.left = new TreeNode(values[i].Value);
                queue.Enqueue(node.left);
            }
            i++;
            if (i < values.Length && values[i] != null)
            {
                node.right = new TreeNode(values[i].Value);
                queue.Enqueue(node.right);
            }
            i++;
        }
        return root;
    }

    // Turns a tree back into LeetCode's level-order format (trailing nulls removed).
    public static int?[] ToLevelOrder(TreeNode root)
    {
        var result = new List<int?>();
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            TreeNode node = queue.Dequeue();
            if (node == null)
            {
                result.Add(null);
                continue;
            }
            result.Add(node.val);
            queue.Enqueue(node.left);
            queue.Enqueue(node.right);
        }
        while (result.Count > 0 && result[^1] == null) result.RemoveAt(result.Count - 1);
        return result.ToArray();
    }

    // Finds the node with the given value (first match), or null.
    public static TreeNode Find(TreeNode root, int value)
    {
        if (root == null) return null;
        if (root.val == value) return root;
        return Find(root.left, value) ?? Find(root.right, value);
    }
}
