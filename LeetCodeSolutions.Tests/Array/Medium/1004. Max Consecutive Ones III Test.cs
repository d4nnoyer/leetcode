namespace LeetCodeSolutions.Tests.Array.Medium;

public class Max_Consecutive_Ones_III_Test {
    
    [TestCase(new[]{1,1,1,0,0,0,1,1,1,1,0},  2, 6)]
    [TestCase(new[]{0,0,1,1,0,0,1,1,1,0,1,1,0,0,0,1,1,1,1},  3, 10)]
    [TestCase(new[]{1},  1, 1)]
    [TestCase(new[]{0},  1, 1)]
    [TestCase(new[]{0,0},  1, 1)]
    public void Test(int[] nums, int k, int expectedResult)
    {
        var maxSize = Max_Consecutive_Ones_III.LongestOnes(nums, k);
        
        Assert.That(maxSize, Is.EqualTo(expectedResult));
    }
}