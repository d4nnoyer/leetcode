namespace LeetCodeSolutions.Tests.Array.Medium;

public class Rotate_Array_Test {
    
    [TestCaseSource(nameof(_testCaseSource))]
    public void Test(int[] nums, int offset, int[] result) 
    {
        Rotate_Array.Rotate(nums, offset);
                
        Assert.That(nums, Is.EqualTo(result));
    }
    
    private static object[] _testCaseSource = { 
        new object[] {new[]{1,2,3,4,5}, 2, new[]{4,5,1,2,3}},
        new object[] {new[]{1,2,3,4}, 2, new[]{3,4,1,2}},
        new object[] {new[]{1,2,3,4,5}, 7, new[]{4,5,1,2,3}},
        new object[] {new[]{1,2,3,4,5}, 0, new[]{1,2,3,4,5}},
        new object[] {new[]{1,2,3,4,5}, 5, new[]{1,2,3,4,5}},
        new object[] {new[]{1,2,3,4,5,6}, 3, new[]{4,5,6,1,2,3}},
        new object[] {new[]{1,2,3,4,5,6}, 2, new[]{5,6,1,2,3,4}},
        new object[] {new[]{1}, 5, new[]{1}},
    };
    
}