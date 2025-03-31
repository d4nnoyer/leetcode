using LeetCodeSolutions.Solutions.HashTable.Medium;

namespace LeetCodeSolutions.Tests.HashTable.Medium;

internal class Max_Number_of_K_Sum_Pairs_Test {
    
    [TestCase(new[]{1,2,3,4},  5, 2)]
    [TestCase(new[]{3,1,3,4,3},  6, 1)]
    public void Test(int[] nums, int k, int expectedResult)
    {
        var number = Max_Number_of_K_Sum_Pairs.MaxOperations(nums, k);
        
        Assert.That(number, Is.EqualTo(expectedResult));
    }
}