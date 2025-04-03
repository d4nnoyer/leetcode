namespace LeetCodeSolutions.Tests.HashTable.Medium;

public class Find_the_Difference_of_Two_Arrays_Test {
    
    [TestCaseSource(nameof(_testCaseSource))]
    public void Test(int[] nums1, int[] nums2, int[][] expectedResult)
    {
        var diffs = Find_the_Difference_of_Two_Arrays.FindDifference(nums1, nums2);
        
        Assert.That(diffs, Is.EqualTo(expectedResult));
    }
    
    private static object[] _testCaseSource =
    [
        new object[] { new[]{1,2,3}, new[]{2,4,6}, new int[][]{[1,3], [4,6]}},
        new object[] { new[]{1,2,3,3}, new[]{1,1,2,2}, new int[][]{[3], []}},
    ];
}