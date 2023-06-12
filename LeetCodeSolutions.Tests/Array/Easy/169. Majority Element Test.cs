namespace LeetCodeSolutions.Tests.Array.Easy;

public class Majority_Element_Test {
    
    [TestCaseSource(nameof(_testCaseSource))]
    public void Test(int[] nums, int result) 
    {
        var majority = Majority_Element.MajorityElement(nums);
                
        Assert.That(majority, Is.EqualTo(result));
    }
    
    private static object[] _testCaseSource = { 
        new object[] {new[]{3,2,3}, 3},
        new object[] {new[]{7}, 7},
        new object[] {new[]{2,2,1,1,1,2,2}, 2},

    };
    
}