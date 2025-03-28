namespace LeetCodeSolutions.Tests.String.Easy;

public class Merge_Strings_Alternately_Test {
    
    [TestCaseSource(nameof(_testCaseSource))]
    public void Test(string word1, string word2, string expectation) 
    {
        var result = Merge_Strings_Alternately.MergeAlternately(word1, word2);
                
        Assert.That(result, Is.EqualTo(expectation));
    }
    
    private static object[] _testCaseSource = { 
        new object[] {"abc", "pqr", "apbqcr"},
        new object[] {"ab", "pqrs", "apbqrs"},
        new object[] {"abcd", "pq", "apbqcd"},
    };
}