namespace LeetCodeSolutions.Solutions.Array.Medium;

public static class Best_Time_to_Buy_and_Sell_Stock_II {
    
    public static int MaxProfit(int[] prices)
    {
        int cumulativeProfit = 0;

        for (int rightPtr = 1; rightPtr < prices.Length; rightPtr++)
        {
            if ( prices[rightPtr] > prices[rightPtr - 1]) 
                cumulativeProfit += prices[rightPtr] - prices[rightPtr - 1];
        }

        return cumulativeProfit;
    }
}