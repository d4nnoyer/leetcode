namespace LeetCodeSolutions.Tests.HashTable.Easy;

public class Minimum_Operations_to_Make_Array_Values_Equal_to_K_Test {
    
    [TestCase(new[]{5,2,5,4,5}, 2, 2)]
    [TestCase(new[]{2,1,2}, 2, -1)]
    [TestCase(new[]{9,7,5,3}, 1, 4)]
    public void Test(int[] nums, int k, int expectedResult)
    {
        var result = Minimum_Operations_to_Make_Array_Values_Equal_to_K.MinOperations(nums, k);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}