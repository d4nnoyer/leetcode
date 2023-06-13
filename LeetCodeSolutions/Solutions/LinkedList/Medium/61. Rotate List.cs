using LeetCodeSolutions.Shared.Model;

namespace LeetCodeSolutions.Solutions.LinkedList.Medium;

public class Rotate_List {
    
    public static ListNode RotateRight(ListNode head, int k)
    {
        if (head == null || k == 0) return head;

        var count = 1;
        var tail = head;

        while (tail.next != null)
        {
            tail = tail.next;
            count++;
        }

        tail.next = head;// Cycling a list

        k %= count;//Removing extra steps

        if (k != 0)
        {
            for (var i = 0; i < count - k; i++)
            {
                tail = tail.next;
            }
        }

        var newHead = tail.next;
        tail.next = null;

        return newHead;
    }
}