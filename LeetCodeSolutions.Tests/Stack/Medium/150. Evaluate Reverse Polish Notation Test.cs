using LeetCodeSolutions.Solutions.Stack.Medium;

namespace LeetCodeSolutions.Tests.Stack.Medium;

public class Evaluate_Reverse_Polish_Notation_Test {
    
    [TestCase(new string[]{"2","1","+","3","*"}, 9)]
    [TestCase(new string[]{"4","13","5","/","+"}, 6)]
    [TestCase(new string[]{"10","6","9","3","+","-11","*","/","*","17","+","5","+"}, 22)]
    public void Test(string[] tokens, int expectedResult) 
    {
        var result = Evaluate_Reverse_Polish_Notation.EvalRPN(tokens);
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}