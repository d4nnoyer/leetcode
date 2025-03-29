namespace LeetCodeSolutions.Tests.Array.Medium;

public class Jump_Game_II_Test {
    
    [TestCase(new[]{2,3,1,1,4},  2)]
    [TestCase(new[]{2,3,0,1,4},  2)]
    public void Test(int[] nums, int expectedResult)
    {
        var minimumJumps = Jump_Game_II.Jump(nums);
        
        Assert.That(minimumJumps, Is.EqualTo(expectedResult));
    }
}