namespace LeetCodeSolutions.Tests.HashTable.Easy;

public class Contains_Duplicate_II_Test {
    
    [TestCase(new[]{1,2,3,1}, 3, true)]
    [TestCase(new[]{1,0,1,1}, 1, true)]
    [TestCase(new[]{1,2,3,1,2,3}, 2, false)]
    public void Test(int[] nums, int k, bool expectedResult)
    {
        var hasDuplicate = Contains_Duplicate_II.ContainsNearbyDuplicate(nums, k);
        
        Assert.That(hasDuplicate, Is.EqualTo(expectedResult));
    }
}