namespace LeetCodeSolutions.Tests.LinkedList.Easy;

public class Linked_List_Cycle_Test {
    
    [TestCaseSource(nameof(_testCaseSource))]
    public void Test(ListNode head, bool result)
    {
        var hasCycle = Linked_List_Cycle.HasCycle(head);
                
        Assert.That(hasCycle, Is.EqualTo(result));
    }
    
    private static object?[] _testCaseSource = {
        new object[]
        {
            new ListNode(5, null),
            false,
        },
    };
    
}