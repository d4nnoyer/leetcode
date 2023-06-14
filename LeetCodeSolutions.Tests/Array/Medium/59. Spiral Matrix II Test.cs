namespace LeetCodeSolutions.Tests.Array.Medium;

public class Spiral_Matrix_II_Test {
    
    [TestCaseSource(nameof(_testCaseSource))]
    public void Test(int n, int[][] result) 
    {
        var matrix = Spiral_Matrix_II.GenerateMatrix(n);
                
        Assert.That(matrix, Is.EqualTo(result));
    }
    
    private static object[] _testCaseSource = { 
        new object[]
        {
            1,
            new[]
            {
                new[] {1},
            },
        },
        new object[]
        {
            2,
            new[]
            {
                new[] {1,2},
                new[] {4,3},
            },
        },
        new object[]
        {
            3,
            new[]
            {
                new[] {1,2,3},
                new[] {8,9,4},
                new[] {7,6,5},
            },
        },
      
    };
    
}