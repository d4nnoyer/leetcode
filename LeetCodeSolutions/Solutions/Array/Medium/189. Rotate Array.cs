namespace LeetCodeSolutions.Solutions.Array.Medium;

public class Rotate_Array {
    
    public static void Rotate(int[] nums, int k)
    {
        k %= nums.Length;
        
        if (nums.Length == 0 || k <= 0)
            return;
            
        int movedCount = 0;
        int start = 0;
        int currentIndex = 0;
        int elementToMove = nums[0];
        
        while (movedCount < nums.Length)
        {
            do
            {
                var newIndex = (currentIndex+k) % nums.Length;
                (nums[newIndex], elementToMove) = (elementToMove, nums[newIndex]);
                currentIndex = newIndex;
                movedCount++;
            } while (currentIndex != start);
            
            currentIndex = ++start;
            elementToMove = nums[currentIndex];
        }
    }
    
}