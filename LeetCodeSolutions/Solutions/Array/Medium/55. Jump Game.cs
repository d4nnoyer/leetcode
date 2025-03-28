namespace LeetCodeSolutions.Solutions.Array.Medium;

public static class Jump_Game {
    
    public static bool CanJump(int[] nums)
    {
        var numsSpan = nums.AsSpan();
        for (int i = 0; i < numsSpan.Length - 1; i++)
        {
            if (numsSpan[i] > numsSpan.Length - 1 - i)
                return true;
            
            if (numsSpan[i] != 0) 
                continue;
            
            while (i < numsSpan.Length - 2 && numsSpan[i+1] == 0 ) 
                i++;
            if (CanJumpOverPuddle(numsSpan[..i]) is false)
                return false;
        }
        
        return true;
    }

    private static bool CanJumpOverPuddle(ReadOnlySpan<int> prevNums)
    {
        for (int i = 1; i <= prevNums.Length; i++)
            if (prevNums[^i] > i)
                return true;
        
        return false;
    }
}