namespace LeetCodeSolutions.Tests.Array.Easy;

public class Find_the_Highest_Altitude_Test {
    
    [TestCase(new[]{-5,1,5,0,-7}, 1)]
    [TestCase(new[]{-4,-3,-2,-1,4,3,2}, 0)]
    public void Test(int[] gain, int expectedResult)
    {
        int highestAttitude = Find_the_Highest_Altitude.LargestAltitude(gain);
        
        Assert.That(highestAttitude, Is.EqualTo(expectedResult));
    }
}