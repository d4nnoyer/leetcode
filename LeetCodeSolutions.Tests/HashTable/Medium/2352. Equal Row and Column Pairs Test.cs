using LeetCodeSolutions.Solutions.HashTable.Medium;

namespace LeetCodeSolutions.Tests.HashTable.Medium;

public class Equal_Row_and_Column_Pairs_Test {
    
    [TestCaseSource(nameof(_testCaseSource))]
    public void Test(int[][] grid, int expectedResult)
    {
        var number = Equal_Row_and_Column_Pairs.EqualPairs(grid);
        
        Assert.That(number, Is.EqualTo(expectedResult));
    }
    
    private static object[] _testCaseSource =
    [
        new object[] { new int[][]{[3,2,1],[1,7,6],[2,7,7]}, 1},
        new object[] { new int[][]{[3,1,2,2],[1,4,4,5],[2,4,2,2],[2,4,2,2]}, 3},
    ];
}