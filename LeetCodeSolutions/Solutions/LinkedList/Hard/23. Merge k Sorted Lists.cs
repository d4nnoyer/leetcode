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

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
    }

    public static ListNode FromArray(int[] nums)
    {
        var head = new ListNode(nums[0]);
        var currentNode = head;

        for (int i = 1; i < nums.Length; i++)
        {
            currentNode.next = new ListNode(nums[i]);
            currentNode = currentNode.next;
        }

        return head;
    }

    public int[] ToArray()
    {
        var nums = new List<int>();
        var currentNode = this;
        nums.Add(currentNode.val);
        
        while (currentNode.next is not null)
        {
            currentNode = currentNode.next;
            nums.Add(currentNode.val);
        }

        return nums.ToArray();
    }
}