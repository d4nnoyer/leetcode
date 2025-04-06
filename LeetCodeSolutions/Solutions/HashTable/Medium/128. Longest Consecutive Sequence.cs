namespace LeetCodeSolutions.Solutions.HashTable.Medium;

public class Longest_Consecutive_Sequence {
    
    public static int LongestConsecutive(int[] nums)
    {
        if (nums.Length is 0 or 1) 
            return nums.Length;
        
        var maxSequenceLength = 0;
        var values = new Dictionary<int, int>();
        foreach (var num in nums) 
            values.TryAdd(num, 0);

        foreach(var key in values.Keys)
        {
            var value = key;
            if(values.ContainsKey(value - 1))
                continue;
            var currentSequenceLength = 1;
            while(values.ContainsKey(++value)) 
                currentSequenceLength++;
            
            maxSequenceLength = Math.Max(currentSequenceLength, maxSequenceLength);
        }

        return maxSequenceLength;
    }
}