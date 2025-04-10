namespace LeetCodeSolutions.Solutions.DynamicProgramming.Medium;

public class Partition_Equal_Subset_Sum {
    
    public static bool CanPartition(int[] nums)
    {
        var sum = 0;
        foreach (var num in nums)
            sum += num;
        if (sum % 2 == 1)
            return false;

        var targetSum = sum / 2;
        Span<bool> possibleSums = stackalloc bool[targetSum + 1];
        possibleSums[0] = true;

        foreach (var num in nums)
            for (int currSum = targetSum; currSum >= num; currSum--)
            {
                possibleSums[currSum] = possibleSums[currSum] || possibleSums[currSum - num];
                if (possibleSums[targetSum]) return true;
            }

        return possibleSums[targetSum];
    }
}