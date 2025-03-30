namespace LeetCodeSolutions.Tests.Array.Easy;

public class Maximum_Average_Subarray_I_Test {
    
    [TestCase(new[]{1,12,-5,-6,50,3}, 4, 12.75000)]
    [TestCase(new[]{7}, 1, 7.00000)]
    public void Test(int[] nums, int k, double expectedResult)
    {
        var maxAverage = Maximum_Average_Subarray_I.FindMaxAverage(nums, k);
            
        Assert.That(maxAverage, Is.EqualTo(expectedResult).Within(0.00001));
    }   
}