using LeetCodeSolutions.Solutions.TwoPointers.Medium;

namespace LeetCodeSolutions.Tests.TwoPointers.Medium;

internal class Container_With_Most_Water_Test {
    
    [TestCase(new[]{1,8,6,2,5,4,8,3,7}, 49)]
    [TestCase(new[]{1,1}, 1)]
    [TestCase(new[]{8,7,2,1}, 7)]
    public void Test(int[] heights, int expectedResult) 
    {
        var maxAMount = Container_With_Most_Water.MaxArea(heights);
        Assert.That(maxAMount, Is.EqualTo(expectedResult));
    }
}