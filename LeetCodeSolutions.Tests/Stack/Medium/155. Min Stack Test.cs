using LeetCodeSolutions.Solutions.Stack.Medium;

namespace LeetCodeSolutions.Tests.Stack.Medium;

public class Min_Stack_Test {

    [TestCase]
    public void TestMinStack()
    {
        int min;
        var minStack = new MinStack();
        minStack.Push(2);
        minStack.Push(0);
        minStack.Push(3);
        minStack.Push(0);
        
        minStack.Pop();
        min = minStack.GetMin();
        Assert.That(min, Is.EqualTo(0));
        
        minStack.Pop();
        min = minStack.GetMin();
        Assert.That(min, Is.EqualTo(0));
        
        minStack.Pop();
        min = minStack.GetMin();
        Assert.That(min, Is.EqualTo(2));
    }
}