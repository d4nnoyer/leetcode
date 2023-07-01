namespace LeetCodeSolutions.Tests.Array.Medium;

public class Top_K_Frequent_Elements_Test {
    
    [TestCaseSource(nameof(_testCaseSource))]
    public void Test(int[] nums, int k, int[] result) 
    {
        var topKFrequent = Top_K_Frequent_Elements.TopKFrequent(nums, k);
                
        Assert.That(topKFrequent, Is.EqualTo(result));
    }
    
    private static object[] _testCaseSource = { 
        new object[] {new[]{3,2,3}, 1, new[]{3}},
        new object[] {new[]{-1,-1}, 1, new[]{-1}},
        new object[] {new[]{1,2}, 2, new[]{1,2}},
        new object[] {new[]{1,1,1,2,2,3}, 2, new[]{1,2}},
    };
    
}