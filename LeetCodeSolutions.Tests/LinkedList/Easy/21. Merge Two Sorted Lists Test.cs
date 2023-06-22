namespace LeetCodeSolutions.Tests.LinkedList.Easy;

public class Merge_Two_Sorted_Lists_Test {
    
    [TestCaseSource(nameof(_testCaseSource))]
    public void Test(ListNode listA, ListNode listB, ListNode result)
    {
        var mergedList = Merge_Two_Sorted_Lists.MergeTwoLists(listA, listB);
                
        Assert.That(mergedList.ToArray(), Is.EqualTo(result.ToArray()));
    }
    
    private static object[] _testCaseSource = {
        new object[] {
            ListNode.FromArray(1,2,4),
            ListNode.FromArray(1,3,4),
            
            ListNode.FromArray(1, 1, 2, 3, 4, 4)
        },
        
        new object[] {
            ListNode.FromArray(1,2,4),
            ListNode.FromArray(1,3,4,5,6,7),
            
            ListNode.FromArray(1, 1, 2, 3, 4, 4,5,6,7)
        },

    };
    
}