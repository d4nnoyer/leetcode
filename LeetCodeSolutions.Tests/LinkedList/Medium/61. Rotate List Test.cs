namespace LeetCodeSolutions.Tests.LinkedList.Medium;

public class Rotate_List_Test {
    
    [TestCaseSource(nameof(_testCaseSource))]
    public void Test(ListNode list, int offset, ListNode result)
    {
        var rotatedList = Rotate_List.RotateRight(list, offset);
                
        Assert.That(rotatedList?.ToArray(), Is.EqualTo(result?.ToArray()));
    }
    
    private static object[] _testCaseSource = {
        new object[] {
            ListNode.FromArray(1,2,3,4,5),
            2,
            ListNode.FromArray(4,5,1,2,3)
        },
        new object[] {
            ListNode.FromArray(1),
            2,
            ListNode.FromArray(1)
        },
        new object[] {
            ListNode.FromArray(1,2,3,4,5),
            17,
            ListNode.FromArray(4,5,1,2,3)
        },
        new object[] {
            ListNode.FromArray(1,2),
            11,
            ListNode.FromArray(2,1)
        },
        new object?[] {
            null,
            11,
            null
        },
        new object[] {
            ListNode.FromArray(1,2,3),
            0,
            ListNode.FromArray(1,2,3)
        },
        new object[] {
            ListNode.FromArray(1,2),
            2,
            ListNode.FromArray(1,2)
        },

    };
    
}