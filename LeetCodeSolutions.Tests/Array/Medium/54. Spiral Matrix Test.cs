namespace LeetCodeSolutions.Tests.Array.Medium;

public class Spiral_Matrix_Test {
    
    [TestCaseSource(nameof(_testCaseSource))]
    public void Test(int[][] matrix, List<int> result) 
    {
        var spiralOrder = Spiral_Matrix.SpiralOrder(matrix);
                
        Assert.That(spiralOrder, Is.EqualTo(result));
    }
    
    private static object[] _testCaseSource = { 
        new object[]
        {
            new[]
            {
                new[] {1,2,3},
                new[] {4,5,6},
                new[] {7,8,9},
            },
            new List<int> {1,2,3,6,9,8,7,4,5}
        },
        new object[]
        {
            new[]
            {
                new[] {1,2,3,4},
                new[] {5,6,7,8},
                new[] {9,10,11,12},
            },
            new List<int> {1,2,3,4,8,12,11,10,9,5,6,7}
        },
        new object[]
        {
            new[]
            {
                new[] {1},
            },
            new List<int> {1}
        },
    };
    
}