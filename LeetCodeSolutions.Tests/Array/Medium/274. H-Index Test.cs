namespace LeetCodeSolutions.Tests.Array.Medium;

internal class H_Index_Test {
    
    [TestCase(new[]{3,0,6,1,5},  3)]
    [TestCase(new[]{3,0,6,1,3,3},  3)]
    [TestCase(new[]{1,3,1},  1)]
    [TestCase(new[]{1},  1)]
    [TestCase(new[]{1,2},  1)]
    [TestCase(new[]{0},  0)]
    [TestCase(new[]{1,1},  1)]
    [TestCase(new[]{20,2,1000},  2)]
    public void Test(int[] nums, int expectedResult)
    {
        var hIndex = H_Index.HIndex(nums);
        
        Assert.That(hIndex, Is.EqualTo(expectedResult));
    }
}