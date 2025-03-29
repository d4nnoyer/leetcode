namespace LeetCodeSolutions.Tests.String.Easy;

public class Greatest_Common_Divisor_of_Strings_Test {
    
    [TestCase("ABCABC", "ABC", "ABC")]
    [TestCase("ABCABCD", "ABC", "")]
    [TestCase("ABABAB", "ABAB", "AB")]
    [TestCase("AAA", "AA", "A")]
    [TestCase("ABABABAB", "ABAB", "ABAB")]
    [TestCase("LEET", "CODE", "")]
    public void Test(string str1, string str2, string expectedGcd) 
    {
        var gcd = Greatest_Common_Divisor_of_Strings.GcdOfStrings(str1, str2);
        Assert.That(gcd, Is.EqualTo(expectedGcd));
    }
}