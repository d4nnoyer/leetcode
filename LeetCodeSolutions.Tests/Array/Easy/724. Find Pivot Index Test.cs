namespace LeetCodeSolutions.Tests.Array.Easy;

public class Find_Pivot_Index_Test {
    
    [TestCase(new[]{1,7,3,6,5,6}, 3)]
    [TestCase(new[]{1,2,3}, -1)]
    [TestCase(new[]{2,1,-1}, 0)]
    [TestCase(new[]{-1,-1,0,0,-1,-1}, 2)]
    public void Test(int[] nums, int expectedResult)
    {
        var pivotIndex = Find_Pivot_Index.PivotIndex(nums);
        
        Assert.That(pivotIndex, Is.EqualTo(expectedResult));
    }
}