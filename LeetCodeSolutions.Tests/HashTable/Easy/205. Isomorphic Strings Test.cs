namespace LeetCodeSolutions.Tests.HashTable.Easy;

public class Isomorphic_Strings_Test {
    
    [TestCase("egg", "add", true)]
    [TestCase("foo", "bar", false)]
    [TestCase("paper", "title", true)]
    [TestCase("badc", "baba", false)]
    public void Test(string s, string t, bool expectedResult)
    {
        var isisIsomorphic = Isomorphic_Strings.IsIsomorphic(s, t);
        
        Assert.That(isisIsomorphic, Is.EqualTo(expectedResult));
    }
}