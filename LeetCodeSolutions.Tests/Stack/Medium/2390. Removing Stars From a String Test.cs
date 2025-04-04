using LeetCodeSolutions.Solutions.Stack.Medium;

namespace LeetCodeSolutions.Tests.Stack.Medium;

public class Removing_Stars_From_a_String_Test {
    
    [TestCase("leet**cod*e", "lecoe")]
    [TestCase("erase*****", "")]
    public void Test(string str, string expectedResult) 
    {
        var result = Removing_Stars_From_a_String.RemoveStars(str);
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}