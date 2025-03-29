namespace LeetCodeSolutions.Solutions.Array.Medium;

public static class Product_of_Array_Except_Self {
    
    public static int[] ProductExceptSelf(int[] nums)
    {
        Span<int> products = stackalloc int[nums.Length];
        products[0] = 1;

        for (var i = 1; i < nums.Length; i++)
            products[i] = products[i - 1] * nums[i - 1];

        for (var i = nums.Length - 2; i >= 0; i--)
        {
            nums[i] *= nums[i + 1];
            products[i] *= nums[i + 1];
        }
        
        products.CopyTo(nums.AsSpan());
        return nums;
    }
}