
namespace LeetCodeSolutions.Tests.Array.Easy;

public class Search_Insert_Position_Test {
    
    //Existing target
    [TestCase(new[]{1,3,5,6}, 1, 0)]
    [TestCase(new[]{1,3,5,6}, 3, 1)]
    [TestCase(new[]{1,3,5,6}, 5, 2)]
    [TestCase(new[]{1,3,5,6}, 6, 3)]
    
    //Non existing target
    [TestCase(new[]{1,3,5,6}, 0, 0)]
    [TestCase(new[]{1,3,5,6}, 7, 4)]
    [TestCase(new[]{1,3,5,6}, 2, 1)]
    [TestCase(new[]{1,3,5,6}, 4, 2)]
    
    [TestCase(new[]{1,3,5}, 0, 0)]
    [TestCase(new[]{1,3,5}, 3, 1)]
    [TestCase(new[]{1,3,5}, 5, 2)]
    
    [TestCase(new[]{1,3,5}, 0, 0)]
    [TestCase(new[]{1,3,5}, 3, 1)]
    [TestCase(new[]{1,3,5}, 6, 3)]
    public void Test(int[] nums, int target, int insertIndex)
    {
        int k = Search_Insert_Position.SearchInsert(nums, target);
            
        Assert.That(k, Is.EqualTo(insertIndex));
    }  
}