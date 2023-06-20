namespace LeetCodeSolutions.Tests.String.Easy;

public class Valid_Parentheses_Test {
    
    [TestCaseSource(nameof(_testCaseSource))]
    public void Test(string str, bool result) 
    {
        var isValidParenthesis = Valid_Parentheses.IsValid(str);
                
        Assert.That(isValidParenthesis, Is.EqualTo(result));
    }
    
    private static object[] _testCaseSource = {
        new object[] {"()", true},
        new object[] {"()[]{}", true},
        new object[] {"([{}])", true},
        new object[] {"(]", false},
        new object[] {"))((", false},
    };
    
}