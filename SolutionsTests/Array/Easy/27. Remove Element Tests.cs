
namespace SolutionsTests.Array.Easy;

public class Remove_Element_Tests {


    [TestCase(new[]{0,1,2,2,3,0,4,2}, 2, 5, new[]{0,1,3,0,4})]
    public void Test(int[] nums, int value, int length, int[] result)
    {
        int k = Remove_Element.Solution(nums, value);
            
        Assert.That(k, Is.EqualTo(length));
        Assert.That(nums[..k], Is.EqualTo(result[..k]));
    }   
        
}  