namespace SolutionsTests.Array.Easy;

public class Merge_Sorted_Array_Test {
    
    [TestCase(new[]{1,2,3,0,0,0}, 3,  new[]{2,5,6}, 3, new[]{1,2,2,3,5,6})]
    public void Test(int[] nums1, int m, int[] nums2, int n, int[] result) 
    {
        Merge_Sorted_Array.Merge(nums1, m, nums2, n);
            
        Assert.That(nums1, Is.EqualTo(result));
    }  
    
}