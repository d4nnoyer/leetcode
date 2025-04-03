namespace LeetCodeSolutions.Tests.HashTable.Easy;

public class Ransom_Note_Test {
    
    [TestCase("a", "b", false)]
    [TestCase("aa", "ab", false)]
    [TestCase("aa", "aab", true)]
    public void Test(string ransomNote, string magazine, bool expectedResult)
    {
        var result = Ransom_Note.CanConstruct(ransomNote, magazine);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}