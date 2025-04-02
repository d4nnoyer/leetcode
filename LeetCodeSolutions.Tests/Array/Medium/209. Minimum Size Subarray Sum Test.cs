namespace LeetCodeSolutions.Tests.Array.Medium;

public class Minimum_Size_Subarray_Sum_Test {
    
    [TestCase(new[]{2,3,1,2,4,3}, 7, 2)]
    [TestCase(new[]{1,4,4}, 4, 1)]
    [TestCase(new[]{1,1,1,1,1,1,1,1}, 11, 0)]
    [TestCase(new[]{2,3,1,1,1,1,1}, 5, 2)]
    [TestCase(new[]{10,2,3}, 6, 1)]
    [TestCase(new[]{1,1}, 3, 0)]
    [TestCase(new[]{8}, 7, 1)]
    public void Test(int[] nums, int target, int expectedResult)
    {
        var maxLength = Minimum_Size_Subarray_Sum.MinSubArrayLen(target, nums);
        
        Assert.That(maxLength, Is.EqualTo(expectedResult));
    }
}