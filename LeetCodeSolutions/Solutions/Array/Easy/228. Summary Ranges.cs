namespace LeetCodeSolutions.Solutions.Array.Easy;

public class Summary_Ranges {
    
    public static IList<string> SummaryRanges(int[] nums)
    {
        if (nums.Length is 0) return [];
        if (nums.Length is 1) return [$"{nums[0]}"];
        
        var result = new List<string>(20);

        var start = 0;
        var end = 0;
        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[end] + 1)
                end++;
            else
            {
                result.Add(end == start ? nums[end].ToString() : $"{nums[start]}->{nums[end]}");
                start = ++end;
            }
        }
        
        result.Add(end == start ? nums[end].ToString() : $"{nums[start]}->{nums[end]}");
        return result;
    }
}