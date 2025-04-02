namespace LeetCodeSolutions.Solutions.Array.Medium;

public static class Minimum_Size_Subarray_Sum {
    public static int MinSubArrayLen(int target, int[] nums)
    {
        int left = 0;
        var currentSum = 0;
        var minLength = int.MaxValue;

        for (int right = 0; right < nums.Length; right++)
        {
            currentSum += nums[right];
            while (currentSum >= target)
            {
                minLength = Math.Min(right - left + 1, minLength);
                currentSum -= nums[left++];
            }
        }
        
        return minLength == int.MaxValue ? 0 : minLength;
    }
}