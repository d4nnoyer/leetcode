namespace LeetCodeSolutions.Tests.Array.Medium;

public class Longest_Subarray_of_1_s_After_Deleting_One_Element_Test {
    
    [TestCase(new[]{1,1,0,1},   3)]
    [TestCase(new[]{0,1,1,1,0,1,1,0,1},   5)]
    [TestCase(new[]{1,1,1},   2)]
    public void Test(int[] nums, int expectedResult)
    {
        var maxSize = Longest_Subarray_of_1_s_After_Deleting_One_Element.LongestSubarray(nums);
        
        Assert.That(maxSize, Is.EqualTo(expectedResult));
    }
}