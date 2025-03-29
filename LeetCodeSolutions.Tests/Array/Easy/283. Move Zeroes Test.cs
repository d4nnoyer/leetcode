namespace LeetCodeSolutions.Tests.Array.Easy;

internal class Move_Zeroes_Test {
    
    [TestCase(new[]{0,1,0,3,12}, new[]{1,3,12,0,0})]
    [TestCase(new[]{0}, new[]{0})]
    public void Test(int[] nums, int[] expectedResult)
    {
        Move_Zeroes.MoveZeroes(nums);
            
        Assert.That(nums, Is.EqualTo(expectedResult));
    }   
}