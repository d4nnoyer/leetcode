namespace LeetCodeSolutions.Tests.String.Easy;

internal class Length_of_Last_Word_Test {
    
    [TestCase("Hello World", 5)]
    [TestCase("   fly me   to   the moon  ", 4)]
    [TestCase("luffy is still joyboy", 6)]
    [TestCase("joyboy", 6)]
    public void Test(string text, int expectedNumber) 
    {
        var number = Length_of_Last_Word.LengthOfLastWord(text);
        Assert.That(number, Is.EqualTo(expectedNumber));
    }
}