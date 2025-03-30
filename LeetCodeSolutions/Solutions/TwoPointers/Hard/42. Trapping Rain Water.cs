namespace LeetCodeSolutions.Solutions.TwoPointers.Hard;

public static class Trapping_Rain_Water {
    
    public static int Trap(int[] height)
    {
        int leftPtr = 0;
        int rightPtr = height.Length - 1;
        int leftMax = 0;
        int rightMax = 0;
        int amount = 0;

        while (leftPtr < rightPtr)
        {
            if (height[leftPtr] < height[rightPtr])
            {
                if (height[leftPtr] >= leftMax)
                    leftMax = height[leftPtr];
                else
                    amount += leftMax - height[leftPtr];
                
                leftPtr++;
            }
            else
            {
                if (height[rightPtr] >= rightMax)
                    rightMax = height[rightPtr];
                else
                    amount += rightMax - height[rightPtr];
                
                rightPtr--;
            }
        }

        return amount;
    }
}