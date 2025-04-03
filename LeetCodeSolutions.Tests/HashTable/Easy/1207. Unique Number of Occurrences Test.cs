namespace LeetCodeSolutions.Tests.HashTable.Easy;

public class Unique_Number_of_Occurrences_Test {
    
    [TestCase(new[]{1,2,2,1,1,3}, true)]
    [TestCase(new[]{1,2}, false)]
    [TestCase(new[]{-3,0,1,-3,1,1,1,-3,10,0}, true)]
    [TestCase(new[]{3,5,-2,-3,-6,-6}, false)]
    public void Test(int[] nums, bool expectedResult)
    {
        var result = Unique_Number_of_Occurrences.UniqueOccurrences(nums);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}