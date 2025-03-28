namespace LeetCodeSolutions.Tests.Array.Medium;

public class Remove_Duplicates_from_Sorted_Array_II_Test {
    
    [TestCase(new[]{1,1,1,2,2,3}, 5, new[]{1,1,2,2,3,0})]
    [TestCase(new[]{0,0,1,1,1,1,2,3,3}, 7, new[]{0,0,1,1,2,3,3,0,0})]
    public void Test(int[] nums, int length, int[] result)
    {
        int k = Remove_Duplicates_from_Sorted_Array_II.RemoveDuplicates(nums);
        
        Assert.Multiple(() =>
        {
            Assert.That(k, Is.EqualTo(length));
            Assert.That(nums[..k], Is.EqualTo(result[..k]));
        });
    }
}