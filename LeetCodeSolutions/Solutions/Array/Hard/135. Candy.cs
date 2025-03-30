namespace LeetCodeSolutions.Solutions.Array.Hard;

public static class Candy {
    
    public static int GetCandy(int[] ratings)
    {
        Span<int> candies = stackalloc int[ratings.Length];
        candies.Fill(1);

        for (var i = 1; i < ratings.Length; i++)
            if (ratings[i] > ratings[i - 1])
                candies[i] = candies[i - 1] + 1;
        
        for (var i = ratings.Length - 2; i >= 0; i--)
            if (ratings[i] > ratings[i + 1])
                candies[i] = Math.Max(candies[i], candies[i + 1] + 1) ;

        var amount = 0;
        foreach (var candy in candies) 
            amount += candy;
        
        return amount;
    }
}