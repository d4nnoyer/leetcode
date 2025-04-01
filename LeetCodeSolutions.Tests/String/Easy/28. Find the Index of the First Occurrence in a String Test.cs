namespace LeetCodeSolutions.Tests.String.Easy;

public class Find_the_Index_of_the_First_Occurrence_in_a_String_Test {
    
    [TestCase("sadbutsad", "sad", 0)]
    [TestCase("satbutsad", "sad", 6)]
    [TestCase("abcdsalsa", "salsa", 4)]
    [TestCase("leetcode", "leeto", -1)]
    public void Test(string text, string search, int expectedIndex)
    {
        var index = Find_the_Index_of_the_First_Occurrence_in_a_String.StrStr(text, search);
        Assert.That(index, Is.EqualTo(expectedIndex));
    }
}