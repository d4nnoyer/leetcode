namespace LeetCodeSolutions.Solutions.Array.Medium;

public static class Jump_Game_II {
    public static int Jump(int[] nums)
    {
        if (nums.Length == 0)
            return 1;
        
        var jumpsCount = 0;
        var current = nums.Length - 1;
        var placeToJumpCurrent = current;

        while (current > 0)
        {
            for (int i = 0; i < current; i++)
            {
                if (nums[i] >= current - i)
                {
                    placeToJumpCurrent = i;
                    break;
                }
            }
            
            if (placeToJumpCurrent < current)
            {
                current = placeToJumpCurrent;
                jumpsCount++;
            }
        }
        
        return jumpsCount;
    }
}