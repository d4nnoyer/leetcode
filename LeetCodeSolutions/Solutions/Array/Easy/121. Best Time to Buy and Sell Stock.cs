namespace LeetCodeSolutions.Solutions.Array.Easy;

//https://leetcode.com/problems/best-time-to-buy-and-sell-stock/description/
public class Best_Time_to_Buy_and_Sell_Stock {
    
    public static int MaxProfit(int[] prices)
    {
        int maxProfit = 0;
        int leftPtr = 0;
        int rightPtr = 1;

        while (rightPtr < prices.Length)
        {
            if (prices[leftPtr] < prices[rightPtr])
            {
                var currProfit = prices[rightPtr] - prices[leftPtr];

                maxProfit = Math.Max(maxProfit, currProfit);
            }
            else
            {
                leftPtr = rightPtr;
            }

            rightPtr++;
        }

        return maxProfit;
    }
    
}