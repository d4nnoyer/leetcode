namespace LeetCodeSolutions.Solutions.HashTable.Easy;

public class Contains_Duplicate {
    
    public static bool ContainsDuplicate(int[] nums)
    {
        if (nums.Length <= 1)
            return false;

        var set = new HashSet<int>();
        foreach (var t in nums)
        {
            if (set.Contains(t)) return true;
            set.Add(t);
        }

        return false;
    }
}

