namespace LeetCodeSolutions.Tests.String.Easy;

internal class Is_Subsequence_Test {
    
    [TestCase("abc", "ahbgdc", true)]
    [TestCase("ace", "abcde", true)]
    [TestCase("ace", "abcdace", true)]
    [TestCase("ace", "abcdaxcye", true)]
    [TestCase("aec", "abcde", false)]
    [TestCase("axc", "ahbgdc", false)]
    [TestCase("", "ahbgdc", true)]
    [TestCase("abc", "", false)]
    [TestCase("a", "a", true)]
    [TestCase("a", "b", false)]
    public void Test(string search, string text, bool expectedResult) 
    {
        var isSubsequence = Is_Subsequence.IsSubsequence(search, text);
        Assert.That(isSubsequence, Is.EqualTo(expectedResult));
    }
}