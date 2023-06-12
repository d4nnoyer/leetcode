namespace LeetCodeSolutions.Tests.Array.Easy;

public class Single_Number_Test {
    
    [TestCaseSource(nameof(_testCaseSource))]
    public void Test(int[] nums, int result) 
    {
        var single = Single_Number.SingleNumber(nums);
                
        Assert.That(single, Is.EqualTo(result));
    }
    
    private static object[] _testCaseSource = { 
        new object[] {new[]{1,1,2,2,3,4,4,5,5,7,8,9,8,9,7}, 3},
        new object[] {new[]{1}, 1},

    };
    
}