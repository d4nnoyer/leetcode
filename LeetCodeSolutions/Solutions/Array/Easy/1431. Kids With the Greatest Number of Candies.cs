namespace LeetCodeSolutions.Solutions.Array.Easy;

public static class Kids_With_the_Greatest_Number_of_Candies {
    public static IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        Span<bool> result = new bool[candies.Length];
        var maxValue = int.MinValue;
        foreach (var t in candies)
            if (t > maxValue)
                maxValue = t;

        for (int i = 0; i < candies.Length; i++)
            if (candies[i] >= maxValue - extraCandies)
                result[i] = true;
        
        return result.ToArray();
    }
}