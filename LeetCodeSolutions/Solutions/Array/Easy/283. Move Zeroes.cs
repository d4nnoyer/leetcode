namespace LeetCodeSolutions.Solutions.Array.Easy;

public static class Move_Zeroes {
    public static void MoveZeroes(int[] nums)
    {
        var zerosCount = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 0)
                zerosCount++;
            else
                nums[i - zerosCount] = nums[i];
        }

        if(zerosCount == 0) return;
        
        for (int i = 1; i <= zerosCount; i++) 
            nums[^i] = 0;
    }
}