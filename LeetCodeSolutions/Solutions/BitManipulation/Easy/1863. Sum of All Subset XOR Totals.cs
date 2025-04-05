namespace LeetCodeSolutions.Solutions.BitManipulation.Easy;

public class Sum_of_All_Subset_XOR_Totals {
    public static int SubsetXORSum(int[] nums)
    {
        var result = 0;
        foreach (var num in nums) 
            result |= num;
        
        return result * (1 << nums.Length - 1);
    }
}