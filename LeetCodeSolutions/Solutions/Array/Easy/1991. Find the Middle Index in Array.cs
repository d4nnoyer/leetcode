namespace LeetCodeSolutions.Solutions.Array.Easy;

public static class Find_the_Middle_Index_in_Array {
    
    public static int FindMiddleIndex(int[] nums)
    {
        var left = 0;
        var right = 0;
        
        foreach (var num in nums)
            right += num; 

        for (int i = 0; i < nums.Length; i++)
        {
            right -= nums[i];
            if (right == left)
                return i;
            left += nums[i];
        }

        return -1;
    }
}