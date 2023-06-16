namespace LeetCodeSolutions.Tests.HashTable.Easy;

public class Contains_Duplicate_Test {
    
    [TestCaseSource(nameof(_testCaseSource))]
    public void Test(int[] nums, bool result)
    {
        var isWithDuplicate = Contains_Duplicate.ContainsDuplicate(nums);

        Assert.That(isWithDuplicate, Is.EqualTo(result));
    }


    private static object[] _testCaseSource;

    static Contains_Duplicate_Test()
    {
        _testCaseSource = new object[] {
            new object[]
            {
                new[]{1,2,3,4,2},
                true
            },
            new object[]
            {
                new[]{1,2,3,4},
                false
            },
        };
    }
    
}