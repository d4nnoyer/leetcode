namespace LeetCodeSolutions.Tests.Array.Easy;

public class Longest_Common_Prefix_Test {
    
    [TestCase(new[]{"flower","flow","flight"}, "fl")]
    [TestCase(new[]{"dog","racecar","car"}, "")]
    public void Test(string[] strs, string expectedPrefix)
    {
        string commonPrefix = Longest_Common_Prefix.LongestCommonPrefix(strs);
        
        Assert.That(commonPrefix, Is.EqualTo(expectedPrefix));
    }
}