
namespace LeetCodeSolutions.Tests.LinkedList.Easy;

public class Intersection_of_Two_Linked_Lists__Test {

    private static object?[] _testCaseSource;
    
    static Intersection_of_Two_Linked_Lists__Test()
    {
        var intersect = ListNode.FromArray(new int[] { 8, 4, 5 });

        var headA = new ListNode(4, new ListNode(1, intersect));
        var headB = new ListNode(5, new ListNode(6, new ListNode(1, intersect)));

        _testCaseSource = new object?[]
        { 
            new object?[]
            {
                headA, headB, intersect
            },
            new object?[]
            {
                ListNode.FromArray(1,2,3), ListNode.FromArray(4,5,6), null
            },
        };
    }
    
    [TestCaseSource(nameof(_testCaseSource))]
    public void Test(ListNode headA, ListNode headB, ListNode result)
    {
        var intersectionNode = Intersection_of_Two_Linked_Lists.GetIntersectionNode(headA, headB);
                
        Assert.That(intersectionNode, Is.EqualTo(result));
    }
    
    
}