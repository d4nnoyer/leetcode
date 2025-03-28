using LeetCodeSolutions.Shared.Model;

namespace LeetCodeSolutions.Solutions.LinkedList.Easy;

public class Linked_List_Cycle {
    
    public static bool HasCycle(ListNode head)
    {
        var slowPtr = head;
        var fastPtr = head;
        
        while (fastPtr is { next: not null }) {
            slowPtr = slowPtr.next;
            fastPtr = fastPtr.next.next;
            if (slowPtr == fastPtr) {
                return true;
            }
        }
        
        return false;
    }
}