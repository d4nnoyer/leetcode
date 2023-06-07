namespace Playground.Solutions.Array.Easy;

public static class Remove_Duplicates_from_Sorted_Array {

    public static int Solution(int[] nums)
    {
        if (nums.Length == 1)
            return 1;

        int length = 1;
        int prevUnique = nums[0];
        int offset = 0;

        for (int index = 1; index < nums.Length - offset;)
        {
            if (nums[index + offset] == prevUnique)
            {
                offset++;
            }
            else
            {
                prevUnique = nums[index + offset];
                nums[index] = prevUnique;
                length++;
                index++;
            }
            
                
        }

        return length;
    }
}