using LeetCodeSolutions.Solutions.DynamicProgramming.Medium;

namespace LeetCodeSolutions.Tests.DynamicProgramming.Medium;

public class Solving_Questions_With_Brainpower_Test {
  
    [TestCaseSource(nameof(_testCaseSource))]
    public void Test(int[][] questions, int expectedResult)
    {
        var maxPoints = Solving_Questions_With_Brainpower.MostPoints(questions);
        
        Assert.That(maxPoints, Is.EqualTo(expectedResult));
    }
    
    private static object[] _testCaseSource =
    [
        new object[] {new int[][]{[1,5]}, 1},
        new object[] {new int[][]{[3,2],[4,3],[4,4],[2,5]}, 5},
        new object[] {new int[][]{[1,1],[2,2],[3,3],[4,4],[5,5]}, 7}
    ];
}