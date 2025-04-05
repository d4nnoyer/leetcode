namespace LeetCodeSolutions.Solutions.Stack.Medium;

public class MinStack
{
    Stack<(int val, int minVal)> stack; 
    int minVal = int.MaxValue;
    public MinStack() {
        stack = new Stack<(int, int)>();
    }
    
    public void Push(int val) {
        minVal = Math.Min(val, minVal);
        stack.Push((val, minVal));
    }
    
    public void Pop()
    {
        stack.Pop();
        minVal = stack.Count > 0 
            ? stack.Peek().minVal 
            : int.MaxValue;
    }
    
    public int Top() {
        return stack.Peek().val;
    }
    
    public int GetMin() {
        return stack.Peek().minVal;
    }
}