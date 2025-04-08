namespace LeetCodeSolutions.Tests.Array.Medium;

public class Set_Matrix_Zeroes_Test {
    
    [TestCaseSource(nameof(_testCaseSource))]
    public void Test(int[][] matrix, int[][] expectedResult)
    {
        Set_Matrix_Zeroes.SetZeroes(matrix);
        Assert.That(matrix, Is.EqualTo(expectedResult));
    }
    
    private static object[] _testCaseSource =
    [
        new object[] {new int[][]{[1,1,1],[1,0,1],[1,1,1]}, new int[][]{[1,0,1],[0,0,0],[1,0,1]}},
        new object[] {new int[][]{[0,1,2,0],[3,4,5,2],[1,3,1,5]}, new int[][]{[0,0,0,0],[0,4,5,0],[0,3,1,0]}},
    ];
}