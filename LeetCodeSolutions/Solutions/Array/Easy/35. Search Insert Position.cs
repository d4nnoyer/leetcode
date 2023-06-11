
namespace LeetCodeSolutions.Solutions.Array.Easy;

public class Search_Insert_Position {
    public static int SearchInsert(int[] nums, int target)
    {
        int leftBound = 0;
        int rightBound = nums.Length - 1;

        while(leftBound < rightBound){
            var currentPos = leftBound + (rightBound - leftBound)/2;
			
            if(nums[currentPos] == target) 
                return currentPos;
            
            if(nums[currentPos] > target) 
                rightBound = currentPos;
            else 
                leftBound = currentPos + 1; 
        }
		
        return nums[leftBound] < target 
            ? leftBound + 1
            : leftBound;
    }
}