using LeetCodeSolutions.Solutions.String.Hard;

namespace LeetCodeSolutions.Tests.String.Hard;

public class Minimum_Window_Substring_Test {
    
    [TestCase("ADOBECODEBANC",  "ABC", "BANC")]
    [TestCase("a",  "a", "a")]
    [TestCase("a",  "aa", "")]
    [TestCase("bdab",  "ab", "ab")]
    [TestCase("bba",  "ab", "ba")]
    [TestCase("abc",  "ac", "abc")]
    [TestCase("bbaac",  "aba", "baa")]
    public void Test(string s, string t, string expectedResult) 
    {
        var solution = new Minimum_Window_Substring();
        var justifiedWords = solution.MinWindow(s, t);
        Assert.That(justifiedWords, Is.EqualTo(expectedResult));
    }
}