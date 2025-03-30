namespace LeetCodeSolutions.Tests.String.Easy;

internal class Reverse_Vowels_of_a_String_Test {
    
    [TestCase("IceCreAm", "AceCreIm")]
    [TestCase("leetcode", "leotcede")]
    [TestCase("aeiou", "uoiea")]
    [TestCase("AEIOU", "UOIEA")]
    public void Test(string text, string expectedResult) 
    {
        var editedText = Reverse_Vowels_of_a_String.ReverseVowels(text);
        Assert.That(editedText, Is.EqualTo(expectedResult));
    }
}