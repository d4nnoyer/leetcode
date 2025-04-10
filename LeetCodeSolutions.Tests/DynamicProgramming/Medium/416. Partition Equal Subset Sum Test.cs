using LeetCodeSolutions.Solutions.DynamicProgramming.Medium;

namespace LeetCodeSolutions.Tests.DynamicProgramming.Medium;

public class Partition_Equal_Subset_Sum_Test {
    
    [TestCase(new[]{1,5,11,5},  true)]
    [TestCase(new[]{1,2,3,5},  false)]
    [TestCase(new[]{23,13,11,7,6,5,5},  true)]
    [TestCase(new[]{1,1},  true)]
    [TestCase(new[]{6,14,19,10,17,10,8,15,16,1,12,4,9,2,15},  true)]
    [TestCase(new[]{4,10,7,9,7,1,11,9,13,15},  true)]
    [TestCase(new[]{9,10,15,3,9,2,9,10,13,1},  false)]
    [TestCase(new[]{100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,
        100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,
        100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,
        100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,
        100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,
        100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,
        100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,100,
        100,100,100,100,100,100,99,97},  
        false)]
    public void Test(int[] nums, bool expectedResult)
    {
        var canBePartitioned = Partition_Equal_Subset_Sum.CanPartition(nums);
        
        Assert.That(canBePartitioned, Is.EqualTo(expectedResult));
    }
}