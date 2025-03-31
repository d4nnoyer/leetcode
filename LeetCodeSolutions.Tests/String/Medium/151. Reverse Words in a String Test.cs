using LeetCodeSolutions.Solutions.String.Medium;

namespace LeetCodeSolutions.Tests.String.Medium;

public class Reverse_Words_in_a_String_Test {
    
    [TestCase("the sky is blue", "blue is sky the")]
    [TestCase("  hello world  ", "world hello")]
    [TestCase("a good   example", "example good a")]
    public void Test(string text, string expectedString) 
    {
        var editedText = Reverse_Words_in_a_String.ReverseWords(text);
        Assert.That(editedText, Is.EqualTo(expectedString));
    }
}