namespace LeetCodeSolutions.Tests.Array.Easy;

public class Count_Equal_and_Divisible_Pairs_in_an_Array_Test {
    
    [TestCase(new[]{3,1,2,2,2,1,3}, 2, 4)]
    [TestCase(new[]{1,2,3,4}, 1, 0)]
    public void Test(int[] nums, int k, long expectedValue)
    {
        var result = Count_Equal_and_Divisible_Pairs_in_an_Array.CountPairs(nums, k);
        
        Assert.That(result, Is.EqualTo(expectedValue));
    }
}