namespace LeetCodeSolutions.Solutions.Array.Medium;

public class Top_K_Frequent_Elements {
    
    public static int[] TopKFrequent(int[] nums, int k)
    {
        var dict = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (dict.ContainsKey(num))
                dict[num]++;
            else 
                dict.Add(num, 1);
        }

        var frequencies = new List<int>[nums.Length + 1];
        foreach (var dictKey in dict.Keys)
        {
            frequencies[dict[dictKey]] ??= new List<int>();
            frequencies[dict[dictKey]].Add(dictKey);;
        }
 
        var topfrequent = new List<int>();

        for (int i = frequencies.Length-1; i >= 0 && topfrequent.Count < k; i--)
        {
            if (frequencies[i] is {Count: > 0})
                topfrequent.AddRange(frequencies[i]);
        }

        return topfrequent.ToArray();
    }
    
}