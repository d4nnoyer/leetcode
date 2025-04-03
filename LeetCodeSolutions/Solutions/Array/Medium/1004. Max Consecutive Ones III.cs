namespace LeetCodeSolutions.Solutions.Array.Medium;

public static class Max_Consecutive_Ones_III {
    
    public static int LongestOnes(int[] nums, int k)
    {
        var left = 0;
        var maxLength = 0;
        var currZeros = 0;
        
        for (int right = 0; right < nums.Length; right++)
        {
            if (nums[right] == 0)
                currZeros++;

            while (currZeros > k && left < right)
            {
                if (nums[left++] == 0)
                    currZeros--;
            }
            
            if(currZeros <= k)
                maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
}