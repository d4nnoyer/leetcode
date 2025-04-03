namespace LeetCodeSolutions.Tests.Array.Medium;

public class Maximum_Value_of_an_Ordered_Triplet_II_Test {
    
    [TestCase(new[]{12,6,1,2,7}, 77)]
    [TestCase(new[]{1,10,3,4,19}, 133)]
    [TestCase(new[]{1,2,3}, 0)]
    [TestCase(new[]{1000000,1,1000000}, 999999000000)]
    [TestCase(new[]{6,11,12,12,7,9,2,11,12,4,19,14,16,8,16}, 190)]
    
    public void Test(int[] nums, long expectedValue)
    {
        var tripletValue = Maximum_Value_of_an_Ordered_Triplet_II.MaximumTripletValue(nums);
        
        Assert.That(tripletValue, Is.EqualTo(expectedValue));
    }
}