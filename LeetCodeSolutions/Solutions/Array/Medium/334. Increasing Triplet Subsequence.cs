namespace LeetCodeSolutions.Solutions.Array.Medium;

public static class Increasing_Triplet_Subsequence {
    
    public static bool IncreasingTriplet(int[] nums)
    {
        var num1 = int.MaxValue;
        var num2 = int.MaxValue;

        foreach (var num in nums)
        {
            if (num <= num1)
                num1 = num;
            else if (num <= num2)
                num2 = num;
            else
                return true; 
        }

        return false;
    }
}