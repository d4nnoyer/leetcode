namespace LeetCodeSolutions.Solutions.DynamicProgramming.Medium;

public class Largest_Divisible_Subset {
    
    public static IList<int> LargestDivisibleSubset(int[] nums)
    {
        if (nums.Length == 1) return nums;
        
        System.Array.Sort(nums);
        var length = nums.Length;
        
        Span<int> largestSubarr = stackalloc int[length];
        Span<int> previousDivider = stackalloc int[length];
        largestSubarr.Fill(1);
        previousDivider.Fill(-1);
        var maxIndex = 0;

        for (int index = 1; index < length; index++)
        {
            for (int subarrIndex = 0; subarrIndex < index; subarrIndex++)
                if (nums[index] % nums[subarrIndex] == 0 && largestSubarr[index] < largestSubarr[subarrIndex] + 1)
                {
                    largestSubarr[index] = largestSubarr[subarrIndex] + 1;
                    previousDivider[index] = subarrIndex;
                }

            if (largestSubarr[index] > largestSubarr[maxIndex])
                maxIndex = index;
        }
        
        var writeIndex = 0;
        for (int readIndex = maxIndex; readIndex >= 0; readIndex = previousDivider[readIndex]) 
            largestSubarr[writeIndex++] = nums[readIndex];
        
        return largestSubarr[..writeIndex].ToArray();
    }
}