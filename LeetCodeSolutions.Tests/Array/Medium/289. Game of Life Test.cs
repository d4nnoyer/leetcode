namespace LeetCodeSolutions.Tests.Array.Medium;

public class Game_of_Life_Test {
    
    [TestCaseSource(nameof(_testCaseSource))]
    public void Test(int[][] matrix, int[][] expectedResult)
    {
        Game_of_Life.GameOfLife(matrix);
        Assert.That(matrix, Is.EqualTo(expectedResult));
    }

    private static object[] _testCaseSource =
    [
        new object[] { new int[][] { [0,1,0],[0,0,1],[1,1,1],[0,0,0] }, new int[][] { [0,0,0],[1,0,1],[0,1,1],[0,1,0] } },
        new object[] { new int[][] { [1,1],[1,0] }, new int[][] { [1,1],[1,1] } },
    ];
}