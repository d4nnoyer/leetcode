namespace LeetCodeSolutions.Tests.Array.Medium;

public class Gas_Station_Test {
    
    [TestCase(new[]{1,2,3,4,5}, new[]{3,4,5,1,2},  3)]
    [TestCase(new[]{5,1,2,3,4}, new[]{4,4,1,5,1},  4)]
    [TestCase(new[]{2,3,4}, new[]{3,4,3},  -1)]
    [TestCase(new[]{2}, new[]{1},  0)]
    [TestCase(new[]{1}, new[]{2},  -1)]
    public void Test(int[] gas, int[] cost, int expectedResult)
    {
        var startingStation = Gas_Station.CanCompleteCircuit(gas, cost);
        
        Assert.That(startingStation, Is.EqualTo(expectedResult));
    }
}