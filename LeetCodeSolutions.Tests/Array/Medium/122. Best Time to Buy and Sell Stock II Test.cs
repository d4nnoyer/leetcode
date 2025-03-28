namespace LeetCodeSolutions.Tests.Array.Medium;

internal class Best_Time_to_Buy_and_Sell_Stock_II_Test {
    
    [TestCaseSource(nameof(_testCaseSource))]
    public void Test( int result, int[] prices) 
    {
        var day = Best_Time_to_Buy_and_Sell_Stock_II.MaxProfit(prices);
                
        Assert.That(day, Is.EqualTo(result));
    }
    
    private static object[] _testCaseSource =
    [
        new object[] {7, new[]{7,1,5,3,6,4}},
        new object[] {4, new[]{1,2,3,4,5}},
        new object[] {0, new[]{7,6,4,3,1}}
    ];
}