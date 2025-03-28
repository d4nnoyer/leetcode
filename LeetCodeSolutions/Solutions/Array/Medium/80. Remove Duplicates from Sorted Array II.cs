namespace LeetCodeSolutions.Solutions.Array.Medium;

public static class Remove_Duplicates_from_Sorted_Array_II {
    public static int RemoveDuplicates(int[] nums) {
        if (nums.Length < 3)
            return nums.Length;

        const int valueMaxCount = 2;

        int currentValue = nums[0];
        int currentValueCount = 1;
        int offset = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            var num = nums[i];
            if (num == currentValue)
                currentValueCount++;
            else
            {
                currentValue = num;
                currentValueCount = 1;
            }

            if (currentValueCount > valueMaxCount) 
                offset++;

            nums[i - offset] = num;
        }

        return nums.Length - offset;
    }
}