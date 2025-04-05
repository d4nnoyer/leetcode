using LeetCodeSolutions.Solutions.HashTable.Hard;

namespace LeetCodeSolutions.Tests.HashTable.Hard;

public class Substring_with_Concatenation_of_All_Words_Test {
    
    [TestCase("barfoothefoobarman", new[]{"foo","bar"}, new[]{0, 9})]
    [TestCase("wordgoodgoodgoodbestword", new[]{"word","good","best","word"}, new int[]{})]
    [TestCase("barfoofoobarthefoobarman", new[]{"bar","foo","the"}, new int[]{6,9,12})]
    [TestCase("wordgoodgoodgoodbestword", new[]{"word","good","best","good"}, new int[]{8})]
    public void Test(string s, string[] words, int[] expectedResult)
    {
        var indices = Substring_with_Concatenation_of_All_Words.FindSubstring(s, words);
        
        Assert.That(indices, Is.EqualTo(expectedResult));
    }
}