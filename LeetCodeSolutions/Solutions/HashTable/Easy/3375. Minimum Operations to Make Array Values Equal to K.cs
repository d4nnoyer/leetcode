namespace LeetCodeSolutions.Solutions.HashTable.Easy;

public class Minimum_Operations_to_Make_Array_Values_Equal_to_K {
    
    public static int MinOperations(int[] nums, int k) {
        var set = new HashSet<int>();
        foreach (var num in nums) 
            if (num < k) 
                return -1;
            else if (num > k) 
                set.Add(num);
                
        return set.Count;
    }
}