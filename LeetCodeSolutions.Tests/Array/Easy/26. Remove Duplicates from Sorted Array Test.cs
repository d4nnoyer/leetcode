
namespace LeetCodeSolutions.Tests.Array.Easy;

internal sealed class Remove_Duplicates_from_Sorted_Array_Test {

    [TestCase(new[]{1,1,2}, 2, new[]{1,2,0})]
    [TestCase(new[]{1,2,3}, 3, new[]{1,2,3})]
    [TestCase(new[]{0,0,1,1,1,2,2,3,3,4}, 5, new[]{0,1,2,3,4,-1,-1,-1,-1,-1})]
    public void Test(int[] nums, int length, int[] result)
    {
        int k = Remove_Duplicates_from_Sorted_Array.Solution(nums);
        
        Assert.Multiple(() =>
        {
            Assert.That(length, Is.EqualTo(k));
            Assert.That(nums[..k], Is.EqualTo(result[..k]));
        });
    }
}