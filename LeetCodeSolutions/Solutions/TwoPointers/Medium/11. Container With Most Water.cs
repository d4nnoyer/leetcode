namespace LeetCodeSolutions.Solutions.TwoPointers.Medium;

public static class Container_With_Most_Water {
    
    public static int MaxArea(int[] height)
    {
        var maxAmount = 0;
        var leftPtr = 0;
        var rightPtr = height.Length - 1;

        while (leftPtr <= rightPtr)
        {
            var amount = (rightPtr - leftPtr) * Math.Min(height[leftPtr], height[rightPtr]);
            maxAmount = Math.Max(maxAmount, amount);
            if (height[leftPtr] < height[rightPtr])
                leftPtr++;
            else 
                rightPtr--;
        }
        
        return maxAmount;
    }
}