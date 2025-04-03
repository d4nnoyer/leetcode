namespace LeetCodeSolutions.Solutions.Array.Medium;

public static class Maximum_Value_of_an_Ordered_Triplet_II {
    //Same as 2873, differs only in constraints
    public static long MaximumTripletValue(int[] nums) {
        long maxTripletValue = 0;
        long maxI = 0;
        long maxDiff = 0;
        
        foreach (var num in nums)
        {
            maxTripletValue = Math.Max(maxTripletValue, maxDiff * num);
            maxDiff = Math.Max(maxDiff, maxI - num);
            maxI = Math.Max(maxI, num);
        }
        
        return maxTripletValue;
    }
}