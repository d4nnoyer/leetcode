namespace LeetCodeSolutions.Solutions.Array.Easy;

public static class Remove_Element {
    public static int Solution(int[] nums, int val)
    {
        var length = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
                nums[length++] = nums[i];
        }

        return length;
    }
}