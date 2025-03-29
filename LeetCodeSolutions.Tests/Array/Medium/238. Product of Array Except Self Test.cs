namespace LeetCodeSolutions.Tests.Array.Medium;

public class Product_of_Array_Except_Self_Test {
    
    [TestCase(new[]{1,2},  new[]{2,1})]
    [TestCase(new[]{1,2,3,4},  new[]{24,12,8,6})]
    [TestCase(new[]{1,2,3,4,5},  new[]{120,60,40,30,24})]
    [TestCase(new[]{-1,1,0,-3,3},  new[]{0,0,9,0,0})]
    public void Test(int[] nums, int[] expectedResult)
    {
        var products = Product_of_Array_Except_Self.ProductExceptSelf(nums);
        
        Assert.That(products, Is.EqualTo(expectedResult));
    }
}