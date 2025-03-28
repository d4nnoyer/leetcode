namespace LeetCodeSolutions.Tests.Array.Easy;

public class Best_Time_to_Buy_and_Sell_Stock_Test {
    
    [TestCaseSource(nameof(_testCaseSource))]
    public void Test( int result, int[] prices) 
    {
        var day = Best_Time_to_Buy_and_Sell_Stock.MaxProfit(prices);
                
        Assert.That(day, Is.EqualTo(result));
    }
    
    private static object[] _testCaseSource = {
        new object[] {5, new[]{7,1,5,3,6,4}},
        new object[] {2, new[]{1,1,1,3,1,2}},
        new object[] {0, new[]{7,6,5,4,3,2,1}},
        new object[] {14, new[]{7,1,5,3,2,15}},
        new object[] {0, new[]{7}},
        new object[] {4, new[]{1,5}},
        new object[] {0, new[]{5,1}},
        new object[] {0, new[]{1,1}},
        new object[] {0, new[]{1,1,0}},
        new object[] {0, new[]{9973,9967,9949,9941,9931,9929,9923,9907,9901,9887,9883,9871,9859,9857,9851,9839,9833,9829,9817,9811,9803,9791,9787,9781,9769,9767,2,1,0,0,0,}},
    };
}