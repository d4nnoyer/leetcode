namespace LeetCodeSolutions.Solutions.Array.Easy;

public static class Maximum_Average_Subarray_I {
    
    public static double FindMaxAverage(int[] nums, int k)
    {
        var sum = 0;
        for (var i = 0; i < k; i++)
        {
            sum += nums[i];
        }

        var maxSum = sum;
        for (var i = k; i < nums.Length; i++)
        {
            sum += nums[i];
            sum -= nums[i - k];
            if (sum > maxSum)
                maxSum = sum;
        }
        
        return maxSum / (double)k;
    }
}