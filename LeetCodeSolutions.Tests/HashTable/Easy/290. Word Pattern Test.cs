namespace LeetCodeSolutions.Tests.HashTable.Easy;

public class Word_Pattern_Test {
    
    [TestCase("abba", "dog cat cat dog", true)]
    [TestCase("abba", "dog cat cat fish", false)]
    [TestCase("aaaa", "dog cat cat dog", false)]
    [TestCase("abba", "dog dog dog dog", false)]
    [TestCase("jquery", "jquery", false)]
    public void Test(string pattern, string text, bool expectedResult)
    {
        var result = Word_Pattern.WordPattern(pattern, text);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}