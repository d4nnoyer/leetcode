namespace LeetCodeSolutions.Solutions.Array.Easy;

public static class Find_Pivot_Index {
    
    public static int PivotIndex(int[] nums)
    {
        Span<int> sums = stackalloc int[nums.Length];
        
        var currentsSum = 0;
        sums[^1] = 0;
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            currentsSum += nums[i+1];
            sums[i] = currentsSum;
        }

        currentsSum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (currentsSum == sums[i])
                return i;
            
            currentsSum += nums[i];
        }

        return -1;
    }
}