using LeetCodeSolutions.Solutions.BitManipulation.Easy;

namespace LeetCodeSolutions.Tests.BitManipulation.Easy;

public class Sum_of_All_Subset_XOR_Totals_Test {
    
    [TestCase(new[]{1, 3}, 6)]
    [TestCase(new[]{5,1,6}, 28)]
    [TestCase(new[]{3,4,5,6,7,8}, 480)]
    public void Test(int[] nums, int expectedResult)
    {
        var indices = Sum_of_All_Subset_XOR_Totals.SubsetXORSum(nums);
        
        Assert.That(indices, Is.EqualTo(expectedResult));
    }
}