
namespace LeetCodeSolutions.Tests.LinkedList.Hard;

public class Merge_k_Sorted_Lists_Test {
    
    [TestCaseSource(nameof(_testCaseSource))]
    public void Test(ListNode[] lists, ListNode result)
    {
        var mergedList = Merge_k_Sorted_Lists.MergeKLists(lists);
                
        Assert.That(mergedList.ToArray(), Is.EqualTo(result.ToArray()));
    }
    
    private static object[] _testCaseSource = {
        new object[] {new[]
        {
            ListNode.FromArray(new[]{1,4,5}),
            ListNode.FromArray(new[]{1,3,4}),
            ListNode.FromArray(new[]{2,6}),
        },
            ListNode.FromArray(new[]{1,1,2,3,4,4,5,6})
        },

    };

}