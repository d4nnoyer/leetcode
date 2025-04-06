using LeetCodeSolutions.Solutions.DynamicProgramming.Medium;

namespace LeetCodeSolutions.Tests.DynamicProgramming.Medium;

public class Largest_Divisible_Subset_Test {
    
    [TestCase(new[]{1,2,3},  new[]{2, 1})]
    [TestCase(new[]{1,2,4,8},  new[]{8,4,2,1})]
    public void Test(int[] nums, int[] expectedResult)
    {
        var largestDivisibleSubset = Largest_Divisible_Subset.LargestDivisibleSubset(nums);
        
        Assert.That(largestDivisibleSubset, Is.EqualTo(expectedResult));
    }
}