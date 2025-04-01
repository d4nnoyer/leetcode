namespace LeetCodeSolutions.Tests.Array.Medium;

public class Increasing_Triplet_Subsequence_Test {
    
    [TestCase(new[]{1,2,3,4,5},  true)]
    [TestCase(new[]{1,2,3},  true)]
    [TestCase(new[]{1},  false)]
    [TestCase(new[]{5,4,3,2,1},  false)]
    [TestCase(new[]{2,1,5,0,4,6},  true)]
    [TestCase(new[]{20,100,10,12,5,13},  true)]
    public void Test(int[] nums, bool expectedResult)
    {
        var hasIncreasingTriplet = Increasing_Triplet_Subsequence.IncreasingTriplet(nums);
        
        Assert.That(hasIncreasingTriplet, Is.EqualTo(expectedResult));
    }
}