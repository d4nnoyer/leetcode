namespace LeetCodeSolutions.Solutions.Array.Easy;

public class Single_Number {
    
    public static int SingleNumber(int[] nums)
    {
        // return nums.Aggregate(0x00000000, (current, t) => current ^ t);
        var result = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            result ^= nums[i];
        }

        return result;
    }

}