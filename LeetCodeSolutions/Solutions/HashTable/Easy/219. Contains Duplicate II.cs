namespace LeetCodeSolutions.Solutions.HashTable.Easy;

public class Contains_Duplicate_II {
    
    public static bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>();
        for (int index = 0; index < nums.Length; index++)
        {
            if (dict.ContainsKey(nums[index]))
                if (index - dict[nums[index]] <= k)
                    return true;
            
            dict[nums[index]] = index;
        }
        
        return false;
    }
}