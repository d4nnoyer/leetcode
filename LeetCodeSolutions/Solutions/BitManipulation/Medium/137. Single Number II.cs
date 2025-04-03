namespace LeetCodeSolutions.Solutions.BitManipulation.Medium;

public static class Single_Number_II {
    
    public static int SingleNumber(int[] nums)
    {
        int ones = 0, twos = 0;
        
        foreach (int num in nums) {
            ones = (ones ^ num) & ~twos;
            twos = (twos ^ num) & ~ones;
        }
        
        return ones;
    }
}