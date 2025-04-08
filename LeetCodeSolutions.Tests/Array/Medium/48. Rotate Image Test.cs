namespace LeetCodeSolutions.Tests.Array.Medium;

public class Rotate_Image_Test {
    
    [TestCaseSource(nameof(_testCaseSource))]
    public void Test(int[][] matrix, int[][] expectedResult)
    {
        Rotate_Image.Rotate(matrix);
        Assert.That(matrix, Is.EqualTo(expectedResult));
    }
    
    private static object[] _testCaseSource =
    [
        new object[] {new int[][]{[5,1,9,11],[2,4,8,10],[13,3,6,7],[15,14,12,16]}, new int[][]{[15,13,2,5],[14,3,4,1],[12,6,8,9],[16,7,10,11]}},
        new object[] {new int[][]{[1,2,3],[4,5,6],[7,8,9]}, new int[][]{[7,4,1],[8,5,2],[9,6,3]}},
        new object[]
        {
            new int[][]
            {
                [5,  1, 9,11, 17],
                [2,  4, 8,10, 18],
                [13, 3, 6, 7, 19],
                [15,14,12,16, 20],
                [21,22,23,24, 25]
            }, 
            new int[][]
            {
                [21,15,13, 2, 5],
                [22,14, 3, 4, 1],
                [23,12, 6, 8, 9],
                [24,16, 7,10, 11],
                [25,20,19,18, 17]
            }
        },

    ];
}