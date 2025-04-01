using LeetCodeSolutions.Solutions.String.Medium;

namespace LeetCodeSolutions.Tests.String.Medium;

internal class String_Compression_Test {
    
    [TestCase(new[]{'a','a','b','b','c','c','c'},  6, new[]{'a','2','b','2','c','3'})]
    [TestCase(new[]{'a','b','b','b','b','b','b','b','b','b','b','b','b'},  4, new[]{'a','b','1','2'})]
    [TestCase(new[]{'a'},  1, new[]{'a'})]
    public void Test(char[] text, int expectedLength, char[] expectedResult) 
    {
        var compressedTextLength = String_Compression.Compress(text);
        Assert.That(compressedTextLength, Is.EqualTo(expectedLength));
        Assert.That(text[..compressedTextLength], Is.EqualTo(expectedResult));
    }
}