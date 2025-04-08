using LeetCodeSolutions.Solutions.Stack.Medium;

namespace LeetCodeSolutions.Tests.Stack.Medium;

public class Decode_String_Test {
    
    [TestCase("3[a]2[bc]", "aaabcbc")]
    [TestCase("3[a2[c]]", "accaccacc")]
    [TestCase("2[abc]3[cd]ef", "abcabccdcdcdef")]
    public void Test(string encoded, string expectedResult) 
    {
        var decoded = Decode_String.DecodeString(encoded);
        Assert.That(decoded, Is.EqualTo(expectedResult));
    }
}