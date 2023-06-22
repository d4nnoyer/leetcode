using LeetCodeSolutions.Shared.Model;

namespace LeetCodeSolutions.Solutions.LinkedList.Easy;

public class Merge_Two_Sorted_Lists {
    
    public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 is null) return list2;
        if (list2 is null) return list1;

        var mergedList = new ListNode();
        var currentNode = mergedList;

        while (list1 is not null && list2 is not null)
        {
            if (list1.val <= list2.val)
            {
                currentNode.next = list1;
                list1 = list1.next;
            }
            else
            {
                currentNode.next = list2;
                list2 = list2.next;
            }

            currentNode = currentNode.next;
        }

        if (list1 is not null) currentNode.next = list1;
        if (list2 is not null) currentNode.next = list2;

        return mergedList.next;
    }
}