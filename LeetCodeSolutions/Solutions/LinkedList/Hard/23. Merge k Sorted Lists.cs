using LeetCodeSolutions.Shared.Model;

namespace LeetCodeSolutions.Solutions.LinkedList.Hard;

public class Merge_k_Sorted_Lists {
    
    public static ListNode MergeKLists(ListNode[] lists)
    {
        if (lists.Length == 0)
            return null;

        var state = new PriorityQueue<ListNode, int>(lists.Length);
        
        foreach (var list in lists.Where(l => l is not null))
        {
                state.Enqueue(list, list.val);
        }

        if (state.TryDequeue(out var currentNode, out _))
        {
            if (currentNode.next is not null)
                state.Enqueue(currentNode.next, currentNode.next.val);
        }
        
        var result = currentNode;
        
        while (state.Count > 0)
        {
            if (state.TryDequeue(out var next, out _))
            {
                if (next.next is not null)
                    state.Enqueue(next.next, next.next.val);
            
                currentNode.next = next;
                currentNode = currentNode.next;
            }
        }

        return result;
    }
    
}
