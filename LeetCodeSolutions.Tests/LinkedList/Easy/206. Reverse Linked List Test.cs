namespace LeetCodeSolutions.Tests.LinkedList.Easy;

public class Reverse_Linked_List_Test {
    
    [TestCaseSource(nameof(_testCaseSource))]
    public void Test(ListNode head,ListNode result)
    {
        var reversedListNode = Reverse_Linked_List.ReverseList(head);
                
        Assert.That(reversedListNode.ToArray(), Is.EqualTo(result.ToArray()));
    }
    
    private static object?[] _testCaseSource = {
        new object[]
        {
            ListNode.FromArray(1,2,3,4,5),
            ListNode.FromArray(5,4,3,2,1), 
        },
        new object[]
        {
            ListNode.FromArray(2),
            ListNode.FromArray(2), 
        },
    };

    
}