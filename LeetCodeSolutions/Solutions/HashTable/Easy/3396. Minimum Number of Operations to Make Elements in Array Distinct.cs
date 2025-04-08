namespace LeetCodeSolutions.Solutions.HashTable.Easy;

public class Minimum_Number_of_Operations_to_Make_Elements_in_Array_Distinct {
    
    public static int MinimumOperations(int[] nums)
    {
        Span<bool> appeared = stackalloc bool[101];
        int i;
        for (i = nums.Length - 1; i >= 0; i--)
            if (appeared[nums[i]]) break;
            else appeared[nums[i]] = true;
        return (int) Math.Ceiling(((double)i + 1) / 3);
    }
}