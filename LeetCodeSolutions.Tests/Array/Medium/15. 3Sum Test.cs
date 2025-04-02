namespace LeetCodeSolutions.Tests.Array.Medium;

public class ThreeSum_Test {
    
    [TestCaseSource(nameof(_testCaseSource))]
    public void Test(int[] nums, int[][] expectedResult)
    {
        var threeSums = ThreeSumClass.ThreeSum(nums);
        Assert.That(threeSums, Is.EqualTo(expectedResult));
    }
    
    private static object[] _testCaseSource =
    [
        new object[] {new[]{-1,0,1,2,-1,-4}, new int[][]{[-1,-1,2],[-1,0,1]}},
        new object[] {new[]{0,0,0}, new int[][]{[0,0,0]}},
        new object[] {new[]{0,1,1}, System.Array.Empty<int[]>()},
        new object[] {new[]{0,1,-1}, new int[][]{[-1,0,1]}},
    ];
}