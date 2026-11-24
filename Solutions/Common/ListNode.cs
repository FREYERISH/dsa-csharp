#nullable disable
namespace Solutions.Common;

// Same shape as LeetCode's ListNode, so your code pastes straight into LeetCode.
public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }

    // ---- Helpers for the tests (not part of LeetCode) ----

    // [1, 2, 3] -> 1 -> 2 -> 3. No values -> null.
    public static ListNode FromArray(params int[] values)
    {
        ListNode dummy = new ListNode();
        ListNode tail = dummy;
        foreach (int v in values)
        {
            tail.next = new ListNode(v);
            tail = tail.next;
        }
        return dummy.next;
    }

    // 1 -> 2 -> 3 -> [1, 2, 3]
    public static int[] ToArray(ListNode head)
    {
        var values = new List<int>();
        int guard = 0;
        while (head != null)
        {
            values.Add(head.val);
            head = head.next;
            if (++guard > 100_000)
                throw new InvalidOperationException("List looks endless: did you create a cycle by mistake?");
        }
        return values.ToArray();
    }

    // Builds a list whose last node points back to the node at index pos (-1 = no cycle).
    public static ListNode FromArrayWithCycle(int[] values, int pos)
    {
        ListNode head = FromArray(values);
        if (pos < 0 || head == null) return head;

        ListNode tail = head;
        ListNode target = null;
        int index = 0;
        while (true)
        {
            if (index == pos) target = tail;
            if (tail.next == null) break;
            tail = tail.next;
            index++;
        }
        tail.next = target;
        return head;
    }
}
