using LeetCodeSolutions.Shared.Model;

namespace LeetCodeSolutions.Solutions.LinkedList.Easy;

public class Reverse_Linked_List {

    public static ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;

        while (head != null)
        {
            var next = head.next;
            head.next = prev;
            prev = head;
            head = next;
        }

        return prev;
    }
}