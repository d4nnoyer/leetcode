namespace LeetCodeSolutions.Tests.Array.Medium;

public class Merge_Intervals_Test {
    
    [TestCaseSource(nameof(_testCaseSource))]
    public void Test(int[][] interval, int[][] expectedResult)
    {
        var mergedInterval = Merge_Intervals.Merge(interval);
        Assert.That(mergedInterval, Is.EqualTo(expectedResult));
    }
    
    private static object[] _testCaseSource =
    [
        new object[] {new int[][]{[1,3],[2,6],[8,10],[15,18]}, new int[][]{[1,6],[8,10],[15,18]}},
        new object[] {new int[][]{[1,4],[4,5]}, new int[][]{[1,5]}},
    ];
}