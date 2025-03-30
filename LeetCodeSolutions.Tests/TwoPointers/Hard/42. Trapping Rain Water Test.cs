using LeetCodeSolutions.Solutions.TwoPointers.Hard;

namespace LeetCodeSolutions.Tests.TwoPointers.Hard;

internal class Trapping_Rain_Water_Test {
    
    [TestCase(new[]{0,1,0,2,1,0,1,3,2,1,2,1}, 6)]
    [TestCase(new[]{4,2,0,3,2,5}, 9)]
    [TestCase(new[]{0,1,2,0,3,0,1,2,0,0,4,2,1,2,5,0,1,2,0,2}, 26)]
    public void Test(int[] heights, int expectedResult) 
    {
        var amount = Trapping_Rain_Water.Trap(heights);
        Assert.That(amount, Is.EqualTo(expectedResult));
    }
}