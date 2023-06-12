using LeetCodeSolutions.Solutions.LinkedList.Hard;

namespace LeetCodeSolutions.Solutions.LinkedList.Easy;

public class Intersection_of_Two_Linked_Lists {
    
    public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        var nodes = new HashSet<ListNode>();

        while (headA != null || headB != null)
        {
            if (headA != null)
            {
                if (nodes.Contains(headA))
                    return headA;
            
                nodes.Add(headA);
                headA = headA.next;
            }

            if (headB != null)
            {
                if (nodes.Contains(headB))
                    return headB;

                nodes.Add(headB);
                headB = headB.next;
            }
        }
        
        return null;
    }
    
}   