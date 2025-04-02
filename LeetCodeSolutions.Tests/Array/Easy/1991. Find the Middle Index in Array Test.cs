namespace LeetCodeSolutions.Tests.Array.Easy;

public class Find_the_Middle_Index_in_Array_Test {
    
    [TestCase(new[]{1,7,3,6,5,6}, 3)]
    [TestCase(new[]{1,2,3}, -1)]
    [TestCase(new[]{2,1,-1}, 0)]
    [TestCase(new[]{-1,-1,0,0,-1,-1}, 2)]
    public void Test(int[] nums, int expectedResult)
    {
        var middleIndex = Find_the_Middle_Index_in_Array.FindMiddleIndex(nums);
        
        Assert.That(middleIndex, Is.EqualTo(expectedResult));
    }
}