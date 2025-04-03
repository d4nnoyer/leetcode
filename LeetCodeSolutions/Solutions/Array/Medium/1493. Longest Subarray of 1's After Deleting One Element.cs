namespace LeetCodeSolutions.Solutions.Array.Medium;

public static class Longest_Subarray_of_1_s_After_Deleting_One_Element {
    
    public static int LongestSubarray(int[] nums)
    {
        const int maxZeros = 1;
        var left = 0;
        var maxLength = 0;
        var currZeros = 0;
        var zerosCount = 0;
        
        for (int right = 0; right < nums.Length; right++)
        {
            if (nums[right] == 0)
            {
                currZeros++;
                zerosCount++;
            }

            while (currZeros > maxZeros && left < right)
            {
                if (nums[left++] == 0)
                    currZeros--;
            }
            
            if(currZeros <= maxZeros)
                maxLength = Math.Max(maxLength, right - left + 1);
        }

        var needToDecre = zerosCount == 0 || currZeros > 0;
        return maxLength - (needToDecre ? 1 : 0);
    }
}