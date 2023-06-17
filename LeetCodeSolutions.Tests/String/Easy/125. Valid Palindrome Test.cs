
namespace LeetCodeSolutions.Tests.String.Easy;

public class Valid_Palindrome_Test {
    
    [TestCaseSource(nameof(_testCaseSource))]
    public void Test(string str, bool result) 
    {
        var isPalindrome = Valid_Palindrome.IsPalindrome(str);
                
        Assert.That(isPalindrome, Is.EqualTo(result));
    }
    
    private static object[] _testCaseSource = { 
        new object[] {"A man, a plan, a canal: Panama", true},
        new object[] {"race a car", false},
        new object[] {"", true},
        new object[] {" ", true},
        new object[] {".,", true},

    };
    
}