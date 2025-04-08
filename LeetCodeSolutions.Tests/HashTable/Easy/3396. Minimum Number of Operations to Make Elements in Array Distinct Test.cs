namespace LeetCodeSolutions.Tests.HashTable.Easy;

public class Minimum_Number_of_Operations_to_Make_Elements_in_Array_Distinct_Test {
    
    [TestCase(new int[]{1,2,3,4,2,3,3,5,7}, 2)]
    [TestCase(new int[]{4,5,6,4,4}, 2)]
    [TestCase(new int[]{6,7,8,9}, 0)]
    public void Test(int[] nums, int expectedResult)
    {
        var operationsCount = Minimum_Number_of_Operations_to_Make_Elements_in_Array_Distinct.MinimumOperations(nums);
        
        Assert.That(operationsCount, Is.EqualTo(expectedResult));
    }
}