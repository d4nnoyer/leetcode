using LeetCodeSolutions.Solutions.HashTable.Medium;

namespace LeetCodeSolutions.Tests.HashTable.Medium;

public class Determine_if_Two_Strings_Are_Close_Test {
    
    [TestCase("abc", "bca", true)]
    [TestCase("a", "aa", false)]
    [TestCase("cabbba", "abbccc", true)]
    [TestCase("uau", "ssx", false)]
    [TestCase("aaabbbbccddeeeeefffff", "aaaaabbcccdddeeeeffff", false)]//342255 523344
    public void Test(string word1, string word2, bool expectedResult)
    {
        var isClose = Determine_if_Two_Strings_Are_Close.CloseStrings(word1, word2);
        
        Assert.That(isClose, Is.EqualTo(expectedResult));
    }
}