namespace LeetCodeSolutions.Solutions.Array.Easy;

public class Count_Equal_and_Divisible_Pairs_in_an_Array {
    
    public static int CountPairs(int[] nums, int k)
    {
        var result = 0;
        for (int i = 0; i < nums.Length - 1; i++)
        for (int j = i + 1; j < nums.Length; j++)
        {
            if ((i * j) % k > 0)
                continue;
            if (nums[i] == nums[j])
                result++;
        }

        return result;
    }

}