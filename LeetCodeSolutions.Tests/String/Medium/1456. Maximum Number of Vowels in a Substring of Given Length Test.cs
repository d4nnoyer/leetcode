using LeetCodeSolutions.Solutions.String.Medium;

namespace LeetCodeSolutions.Tests.String.Medium;

public class Maximum_Number_of_Vowels_in_a_Substring_of_Given_Length_Test {
    
    [TestCase("abciiidef", 3, 3)]
    [TestCase("aeiou", 2, 2)]
    [TestCase("aeiou", 5, 5)]
    [TestCase("leetcode", 3, 2)]
    public void Test(string text, int k, int expectedResult) 
    {
        var maxVowels = Maximum_Number_of_Vowels_in_a_Substring_of_Given_Length.MaxVowels(text, k);
        Assert.That(maxVowels, Is.EqualTo(expectedResult));
    }
}