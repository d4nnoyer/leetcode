namespace LeetCodeSolutions.Tests.Array.Medium;

public class Two_Sum_II___Input_Array_Is_Sorted_Test {
    
    [TestCase(new[]{2,7,11,15},  9, new[]{1, 2})]
    [TestCase(new[]{2,3,4},  6, new[]{1, 3})]
    [TestCase(new[]{-1, 0},  -1, new[]{1, 2})]
    [TestCase(new[]{3,24,50,79,88,150,345},  200, new[]{3, 6})]
    [TestCase(new[]{-1,-1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},  -2, new[]{1,2})]
    public void Test(int[] nums, int target, int[] expectedResult)
    {
        var indexes = Two_Sum_II___Input_Array_Is_Sorted.TwoSum(nums, target);
        
        Assert.That(indexes, Is.EqualTo(expectedResult));
    }
}