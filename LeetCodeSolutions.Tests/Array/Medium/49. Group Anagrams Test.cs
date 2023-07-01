namespace LeetCodeSolutions.Tests.Array.Medium;

public class Group_Anagrams_Test {
    
    [TestCaseSource(nameof(_testCaseSource))]
    public void Test(string[] strs, IList<IList<string>> result) 
    {
        var grouppedAnagrams = Group_Anagrams.GroupAnagrams(strs);
        Assert.That(grouppedAnagrams.FirstOrDefault(x => x.Count == result[0].Count)!.ToHashSet().SetEquals(result[0].ToHashSet()), Is.True);
        Assert.That(grouppedAnagrams.FirstOrDefault(x => x.Count == result[1].Count)!.ToHashSet().SetEquals(result[1].ToHashSet()), Is.True);
        Assert.That(grouppedAnagrams.FirstOrDefault(x => x.Count == result[2].Count)!.ToHashSet().SetEquals(result[2].ToHashSet()), Is.True);
    }
    
    private static object[] _testCaseSource = { 
        new object[]
        {
            new []{"eat","tea","tan","ate","nat","bat"},
            new List<IList<string>>
            {
                new List<string> { "bat"},
                new List<string> { "nat","tan"},
                new List<string> { "ate","eat","tea"},
            }            
        },
        new object[]
        {
            new []{""},
            new List<IList<string>>
            {
                new List<string> {""},
            }            
        },
    };
}