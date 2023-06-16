
namespace LeetCodeSolutions.Tests.HashTable.Easy;

public class Valid_Anagram_Test {
    
    [TestCaseSource(nameof(_testCaseSource))]
    public void Test(string s, string t, bool result)
    {
        var isAnagram = Valid_Anagram.IsAnagram(s, t);

        Assert.That(isAnagram, Is.EqualTo(result));
    }


    private static object[] _testCaseSource;

    static Valid_Anagram_Test()
    {
        _testCaseSource = new object[] {
            new object[]
            {
                "nails",
                "snail",
                true
            },
            new object[]
            {
                "abcd",
                "cbfd",
                false
            },
            new object[]
            {
                "nailstt",
                "kksnail",
                false
            },
            new object[]
            {
                "aabbbb",
                "aaaabb",
                false
            },
       
        };
    }
}