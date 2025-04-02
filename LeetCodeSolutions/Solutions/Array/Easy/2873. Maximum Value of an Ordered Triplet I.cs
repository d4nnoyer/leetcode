namespace LeetCodeSolutions.Solutions.Array.Easy;

public static class Maximum_Value_of_an_Ordered_Triplet_I {
    
    public static long MaximumTripletValue(int[] nums)
    {
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