namespace SolutionsTests.Array.Easy;

public class Plus_One_Test {
    
    [TestCase(new[]{1,3,5,6}, new[]{1,3,5,7})]
    [TestCase(new[]{1,3,5,9}, new[]{1,3,6,0})]
    [TestCase(new[]{1,3,9,9}, new[]{1,4,0,0})]
    [TestCase(new[]{9}, new[]{1,0})]
    [TestCase(new[]{9,9,9,9}, new[]{1,0,0,0,0})]
    public void Test(int[] nums, int[] result)
    {
        var answer = Plus_One.PlusOne(nums);
            
        Assert.That(answer, Is.EqualTo(result));
    }  
    
}